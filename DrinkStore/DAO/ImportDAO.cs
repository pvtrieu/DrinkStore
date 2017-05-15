using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class ImportDAO
    {
        public static void insert(Import import)
        {
            using (DSModel model = new DSModel())
            {
                model.Imports.Add(import);
                model.SaveChanges();
            }
        }

        public static void update(Import import)
        {
            using (DSModel model = new DSModel())
            {
                var updateImport = model.Imports.Find(import.ImportID);
                model.Entry(updateImport).CurrentValues.SetValues(import);
                model.SaveChanges();
            }
        }

        public static void delete(Import import)
        {
            using (DSModel model = new DSModel())
            {
                var delImport = model.Imports.Find(import.ImportID);
                model.Imports.Remove(delImport);
                model.SaveChanges();
            }
        }

        public static List<Import> getAll()
        {
            using (DSModel model = new DSModel())
            {
                return model.Imports.ToList();
            }
        }

        public static List<Import> searchByProduct(int productID)
        {
            using (DSModel model = new DSModel())
            {
                return model.Imports.Where(x => x.ProductID == productID).OrderBy(x => x.ImportDate).ToList();
            }
        }
    }
}
