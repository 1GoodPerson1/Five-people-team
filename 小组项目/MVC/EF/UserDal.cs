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
        public List<BoyInfo> BoyInfo()
        {
            Model2 db = new Model2();
            return db.BoyInfo.ToList();
        }
        public int delete(int id)
        {
            Model2 db = new Model2();
            int result = db.Database.ExecuteSqlCommand("delete from BoyInfo where boyid=@boyid", new SqlParameter("@boyid", id));
            return result;
        }
        public static List<loginUser> sellogin()
        {
            Model2 db = new Model2();
            List<loginUser> list = db.Database.SqlQuery<loginUser>("select * from loginUser").ToList();
            return list;
        }
        public static List<BoyInfo> selboy()
        {
            Model2 db = new Model2();
            List<BoyInfo> list = db.Database.SqlQuery<BoyInfo>("select * from BoyInfo").ToList();
            return list;
        }
        public static List<GirlInfo> selgirl()
        {
            Model2 db = new Model2();
            List<GirlInfo> list = db.Database.SqlQuery<GirlInfo>("select * from GirlInfo").ToList();
            return list;
        }
    }
}
