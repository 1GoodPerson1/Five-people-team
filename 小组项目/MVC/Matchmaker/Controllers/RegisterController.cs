using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF;
using Newtonsoft.Json;

namespace Matchmaker.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        [HttpGet]
        public ActionResult Register()
        {
            return View("Register");
        }
        [HttpPost]
        public JsonResult Add(loginUser login)
        {
            int user = UserDal.Userass(login);
            
            if (user > 0)
            {
                
                return Json(1, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(0);
                
            }
            //if (dal.Userass(login) > 0)
            //{
            //    return RedirectToAction("/Login/Index");
            //}
            //else
            //{
            //    return RedirectToAction("/Register/Index");
            //}

        }
    }
}