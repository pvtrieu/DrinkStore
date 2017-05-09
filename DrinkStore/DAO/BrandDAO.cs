using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class BrandDAO
    {
        public static List<Brand> getAll()
        {
            using (DSModel model = new DSModel())
            {
                return model.Brands.ToList();
            }
        }
    }
}
