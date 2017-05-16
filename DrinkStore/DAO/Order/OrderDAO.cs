using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class OrderDAO
    {
        public static List<Order> getAll()
        {
            using (DSModel model = new DSModel())
            {
                return model.Orders.ToList();
            }
        }

        public static void add(Order order)
        {
            using (DSModel model = new DSModel())
            {
                model.Orders.Add(order);
                model.SaveChanges();
            }
        }

    }
}
