using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF;
using Newtonsoft.Json;

namespace Matchmaker.Controllers
{
    public class PerInfoController : Controller
    {
        // GET: PerInfo
        public ActionResult Perinfo()
        {
            if (Session["shenfen"] != null)
            {
                ViewData["sesson"] = Session["shenfen"];
                ViewData["name"] = Session["name"];
            }
            return View();
        }
        public JsonResult Add(BoyInfo boy)
        {
            int user = UserDal.Ins(boy);

            if (user > 0)
            {

                return Json(1, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(0);

            }
        }
    }
}