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
        public static void insert(Product product)
        {
            if (product != null)
            {
                ProductDAO.insert(product);
            }            
        }

        public static void update(Product product)
        {
            ProductDAO.update(product);
        }

        public static void delete(Product product)
        {
            ProductDAO.delete(product);
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
