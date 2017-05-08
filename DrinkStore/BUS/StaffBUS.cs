using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.DAO;
using DrinkStore.Entities;

namespace DrinkStore.BUS
{
    class StaffBUS
    {
        public static Staff getByID(int id)
        {
            return StaffDAO.getByID(id);
        }
    }
}
