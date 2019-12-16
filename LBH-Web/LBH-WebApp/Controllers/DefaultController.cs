using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LBH_EF_DAL;
using Newtonsoft.Json;



namespace LBH_WebApp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ModelDal dal = new ModelDal();
            List<baoxiu> sel = dal.baoxiu();
            return View(sel);
        }
        public ActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public ActionResult Createmodel(baoxiu baoxiuss)
        {
            ModelDal dal = new ModelDal();
            if (dal.Userass(baoxiuss) > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Create");
            }
        }
        public ActionResult Update(int id)
        {
            ModelDal dal = new ModelDal();
            baoxiu baoxiuss = dal.GetId(id);
            return View(baoxiuss);
        }
        public ActionResult updatemodel(baoxiu baoxiuss)
        {
            ModelDal dal = new ModelDal();
            if (dal.Update(baoxiuss) > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Update");
            }
        }
        public ActionResult Delete(int id)
        {
            ModelDal dal = new ModelDal();
            if (dal.delete(id) > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Update");
            }
        }
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult sel(string UserName, string UserPwd)
        {
            UserInfo user = ModelDal.sel(UserName, UserPwd);
            JsonResult jsonResult = new JsonResult();
            if (user == null)
            {
                return Json(0);
            }
            else
            {
                string json = JsonConvert.SerializeObject(user);
                HttpCookie cookie = new HttpCookie("UserPwd", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(json)));
                Response.Cookies.Add(cookie);
                jsonResult.Data = new { data = user, state = "200" };
                LogHelper.Default.WriteInfo(user.UserName+"登录");
                return Json(jsonResult, JsonRequestBehavior.AllowGet);
            }
        }
    }
}