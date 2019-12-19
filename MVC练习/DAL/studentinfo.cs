using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class studentinfo
    {
        public List<Student> sel()
        {
            Model1 DB = new Model1();
            return DB.Student.ToList();
        }
        public int insert(Student stu)
        {
            Model1 DB = new Model1();
            DB.Student.Add(stu);
          return DB.SaveChanges();
        }
        public Student selID(int Id)
        {
            Model1 DB = new Model1();
          return  DB.Student.FirstOrDefault(p=>p.Id==Id);
        }
        public int update( Student stu)
        {
            Model1 DB = new Model1();
            DB.Entry(stu).State = System.Data.Entity.EntityState.Modified;
            return DB.SaveChanges();
        }
        public List<Class> selClass()
        {
            Model1 DB = new Model1();
           return  DB.Class.ToList();
        }
    }
}
