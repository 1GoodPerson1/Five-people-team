using EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Matchmaker.Controllers
{
    public class GetListController : Controller
    {
        //// GET: GetList
        //Model1 db = new Model1();*
        public ActionResult Index()
        {
            loginDal dal = new loginDal();
            List<loginUser> list = dal.GetloginUser();
            return View(list);
      
        }
    }
}