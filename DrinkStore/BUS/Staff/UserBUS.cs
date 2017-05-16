using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.DAO;
using DrinkStore.Entities;

namespace DrinkStore.BUS
{
    class UserBUS
    {
        public void UserBus()
        {
            
        }

        public static bool valid(string username, string password)
        {
            
            User user = UserDAO.getUser(username);
            if (user.Password == password)
                return true;
            else
                return false;
        }

        public static int getStaffID(string username)
        {
            return UserDAO.getID(username);
        }
        
        
    }
}
