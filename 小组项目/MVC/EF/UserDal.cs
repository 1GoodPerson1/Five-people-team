using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EF;

namespace EF
{
    public class UserDal
    {
        public static List<loginUser> sel()
        {
            Model1 db = new Model1();
            return db.loginUser.ToList();
        }
        public static loginUser sel(string userName, string userPwd)
        {
            return sel().FirstOrDefault(p => p.userName == userName && p.userPwd == userPwd);
        }
    }
}
