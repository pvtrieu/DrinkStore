using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.DAO;
using DrinkStore.Entities;

namespace DrinkStore.BUS
{
    class ProductBUS
    {
        public static bool insert(Product product)
        {
            try
            {
                ProductDAO.insert(product);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool update(Product product)
        {
            try
            {
                ProductDAO.update(product);
                return true;
            }
            catch
            {
                return false;
            }
           
        }

        public static bool delete(Product product)
        {
            try
            {
                ProductDAO.delete(product);
                return true;
            }
            catch
            {
                return false;
            }
           
        }

        public static List<Product> getAll()
        {
            return ProductDAO.getAll();
        }

        public static List<Product> searchByName(string name)
        {
            return ProductDAO.searchByName(name);
        }
    }
}
