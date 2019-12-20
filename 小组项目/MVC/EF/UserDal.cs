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
            Model2 db = new Model2();
            return db.loginUser.ToList();
        }
        public static loginUser sel(string userName, string userPwd)
        {
            return sel().FirstOrDefault(p => p.userName == userName && p.userPwd == userPwd);
        }
        public static int   Userass(loginUser login)
        {
            Model2 db = new Model2();
            db.loginUser.Add(login);
            return db.SaveChanges();
        }
        public static int Ins(BoyInfo boy)
        {
            Model2 db = new Model2();
            db.BoyInfo.Add(boy);
            return db.SaveChanges();
        }
    }
}
