using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC练习.Controllers
{
    public class dome2Controller : Controller
    {
        
        readonly studentinfo studentinfo = new studentinfo();
        // GET: dome2
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult sel()
        {
            var data = studentinfo.selClass();
            return Json(data);
        }
        [HttpPost]
        public JsonResult longsel()
        {
            var data = studentinfo.sel();
            return Json(data);

        }
    }
}