
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EF
{
   public class loginDal
    {
        public List<loginUser> GetloginUser() {
          
                Model1 db = new Model1();
                return db.loginUser.ToList();
            
        }
    }
}