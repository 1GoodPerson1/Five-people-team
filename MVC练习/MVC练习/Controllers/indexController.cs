using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace MVC练习.Controllers
{
    public class indexController : Controller
    {
        // GET: index
        public ActionResult Index()
        {
            studentinfo dal = new studentinfo();
          List<Student> stu=  dal.sel();
            return View(stu);
        }
        public ActionResult insert()
        {
            studentinfo dal = new studentinfo();
            ViewBag.ClassName = dal.selClass().Select(Class => new SelectListItem() { Text = Class.ClassName, Value = Class.Id.ToString() }).ToList();
            return View("insert");
        }
        [HttpPost]
        public ActionResult add(Student stu)
        {
            studentinfo dal = new studentinfo();
            if (dal.insert(stu) > 0)
            {
                return RedirectToAction("Index");
            }
            else {
                return RedirectToAction("insert");
            }
        }
        [HttpPost]
        public ActionResult update(Student stu)
        {
            studentinfo dal = new studentinfo();
            if (dal.update(stu) > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("updateID");
            }
         
        }
        public ActionResult updateID(int id)
        {
            studentinfo dal = new studentinfo();
            return View(dal.selID(id));
        }

    }
}