using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class UserDAO
    {

        

        public static User getUser(string username)
        {
            using (DSModel model = new DSModel())
            {
                var user = model.Users.Where(x => x.Username == username).FirstOrDefault();
                return user;
            }           
            
        }

        public static int getID(string username)
        {
            using (DSModel model = new DSModel())
            {
                var user = model.Users.Where(x => x.Username == username).FirstOrDefault();
                return user.StaffID;
            }
        }

    }
}
