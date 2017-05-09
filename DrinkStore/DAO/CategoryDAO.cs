using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class CategoryDAO
    {
        public  static List<Category> getAll()
        {
            using (DSModel model = new DSModel())
            {
                return model.Categories.ToList();
            }
        }
    }
}
