using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LBH_EF_DAL;
using System.Data;
using System.Data.SqlClient;

namespace LBH_EF_DAL
{
    public class ModelDal
    {
        public List<baoxiu> baoxiu()
        {
            Model1 db = new Model1();
            return db.baoxiu.ToList();
        }

        public int Userass(baoxiu baoxiuss)
        {
            Model1 db = new Model1();
            db.baoxiu.Add(baoxiuss);
            return db.SaveChanges();
        }
        public baoxiu GetId(int id)
        {
            Model1 db = new Model1();
            return db.baoxiu.FirstOrDefault(p => p.baoid == id);
        }
        public int Update(baoxiu baoxiuss)
        {
            Model1 db = new Model1();
            db.Entry(baoxiuss).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }

        public int delete(int id)
        {
            Model1 db = new Model1();
            int result = db.Database.ExecuteSqlCommand("delete from baoxiu where baoid=@baoid", new SqlParameter("@baoid",id));
            return result;
        }

        public static List<UserInfo> sel()
        {
            Model1 db = new Model1();
            return db.UserInfo.ToList();
        }
        public static UserInfo sel(string UserName, string UserPwd)
        {
            return sel().FirstOrDefault(p => p.UserName == UserName && p.UserPwd == UserPwd);
        }
    }
}
