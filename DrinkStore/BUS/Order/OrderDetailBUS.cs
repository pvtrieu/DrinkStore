using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;
using DrinkStore.DAO;

namespace DrinkStore.BUS
{
    class OrderDetailBUS
    {
        public static List<OrderDetail> getAll(Order order)
        {
            return OrderDetailDAO.getAll(order.OrderID);
        }

        public static bool Add(OrderDetail detail)
        {
            try
            {
                OrderDetailBUS.Add(detail);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
