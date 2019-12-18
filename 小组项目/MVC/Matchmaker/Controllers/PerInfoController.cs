using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            }
            return View();
        }
    }
}