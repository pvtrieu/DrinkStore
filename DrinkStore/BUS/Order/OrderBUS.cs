using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;
using DrinkStore.DAO;

namespace DrinkStore.BUS
{
    class OrderBUS
    {
        public static List<Order> getAll()
        {
            return OrderDAO.getAll();
        }

        public static bool add(Order order)
        {
            try
            {
                OrderDAO.add(order);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
