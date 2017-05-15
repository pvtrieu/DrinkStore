using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.DAO;
using DrinkStore.Entities;

namespace DrinkStore.BUS
{
    class ImportBUS
    {
        public static void insert(Import import)
        {
            ImportDAO.insert(import);
        }

        public static void update(Import import)
        {
            ImportDAO.update(import);
        }

        public static void delete(Import import)
        {
            ImportDAO.delete(import);
        }

        public static List<Import> getAll()
        {
            return ImportDAO.getAll();
        }

        public static List<Import> searchByProduct(int productID)
        {
            return ImportDAO.searchByProduct(productID);
        }
    }
}
