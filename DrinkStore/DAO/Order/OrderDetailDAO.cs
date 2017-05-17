using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class OrderDetailDAO
    {
        public static List<OrderDetail> getAll(int orderID)
        {
            using (DSModel model = new DSModel())
            {
                return model.OrderDetails.Where(x => x.OrderID == orderID).ToList();
            }
        }
        public static void Add(OrderDetail orderDetail)
        {
            int? boxQuant = orderDetail.BoxQuant;
            int? unitQuant = orderDetail.UnitQuant;
            boxQuant += (unitQuant / orderDetail.Product.Category.Unit);
            unitQuant = (unitQuant % orderDetail.Product.Category.Unit);
            
            using (DSModel model = new DSModel())
            {
                do
                {
                    Import import = new Import();

                    //Get the current avaiable stock
                    import = model.Imports
                        .Where(x => x.ProductID == orderDetail.ProductID &&
                            (x.CurrentBoxQuant > 0 || x.CurrentUnitQuant >0))
                        .OrderBy(x => x.ImportDate).First();

                    //Decrease current box in stock
                    if (import.CurrentBoxQuant < boxQuant)
                    {
                        boxQuant -= import.CurrentBoxQuant;
                        import.CurrentBoxQuant = 0;
                    }
                    else
                    {
                        import.CurrentBoxQuant -= boxQuant;
                        boxQuant = 0;
                    }

                    //Decrease current unit in stock
                    if (import.CurrentUnitQuant < unitQuant)
                    {
                        if (import.CurrentBoxQuant > 0)
                        {
                            import.CurrentBoxQuant -= 1;
                            import.CurrentUnitQuant += import.Product.Category.Unit;
                            import.CurrentUnitQuant -= unitQuant;
                            unitQuant = 0;
                        }
                        else
                        {
                            unitQuant -= import.CurrentUnitQuant;
                            import.CurrentUnitQuant = 0;
                        }
                    }
                    else
                    {
                        unitQuant -= import.CurrentUnitQuant;
                        import.CurrentUnitQuant = 0;
                    }

                    model.SaveChanges();
                    
                }
                while (boxQuant > 0 || unitQuant > 0);

                //Save orderDetails to database
                model.OrderDetails.Add(orderDetail);
                model.SaveChanges();                                        
            }
        }
    }
}
