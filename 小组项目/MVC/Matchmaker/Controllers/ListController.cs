using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Matchmaker.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult Index()
        {
            if (Session["shenfen"] != null)
            {
                ViewData["sesson"] = Session["shenfen"];
                ViewData["name"] = Session["name"];
            }
            return View();
        }

    }
}