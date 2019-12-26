using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Matchmaker.Controllers
{
    public class BOYController : Controller
    {
        // GET: BOY
        public ActionResult boyList()
        {
            return View();
        }
    }
}