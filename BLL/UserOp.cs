using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserOp
    {
        
        public bool UserAdd(User user)
        {
            if (UserDB.UserList.Any(x=> x.Username==user.Username))
            {
                return false;


            }
            else
            {
                UserDB.UserList.Add(user);
                return true;
            }
               


        }
    }
}
