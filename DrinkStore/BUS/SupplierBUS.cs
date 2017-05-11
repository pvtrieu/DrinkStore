using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.DAO;
using DrinkStore.Entities;

namespace DrinkStore.BUS
{
    class SupplierBUS
    {
        public static List<Supplier> getAll()
        {
            using (DSModel model = new DSModel())
            {
                return model.Suppliers.ToList();
            }
        }
    }
}
