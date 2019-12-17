using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LBH_EF_DAL;
using LBH_WebApp.filer;
using Newtonsoft.Json;

namespace LBH_WebApp.Controllers
{
    public class LoginController : Controller
    {
        
        // GET: Login
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
                Session["user"] = user;
                jsonResult.Data = new { data = user, state = "200" };
                LogHelper.Default.WriteInfo(user.UserName + "登录");
                return Json(jsonResult, JsonRequestBehavior.AllowGet);
            }
        }
    }
}