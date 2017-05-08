using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class StaffDAO
    {
        public static Staff getByID(int id)
        {
            using (DSModel model = new DSModel())
            {
                Staff staff = model.Staffs.Where(x => x.StaffID == id).FirstOrDefault();
                return staff;
            }
        }

    }
}
