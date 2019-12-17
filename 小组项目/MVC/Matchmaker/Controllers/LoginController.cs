using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using EF;

namespace Matchmaker.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        // GET: Login
        public ActionResult Index()
        {            
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult sel(string userName, string userPwd)
        {
            loginUser user = UserDal.sel(userName, userPwd);
            JsonResult jsonResult = new JsonResult();
            if (user == null)
            {
                return Json(0);
            }
            else
            {
                string json = JsonConvert.SerializeObject(user);
                HttpCookie cookie = new HttpCookie("userPwd", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(json)));
                Response.Cookies.Add(cookie);
                Session["user"] = user;
                Session["shenfen"] = user.Userinfo;
                jsonResult.Data = new { data = user, state = "200" };
                //LogHelper.Default.WriteInfo(user.UserName + "登录");
                return Json(jsonResult, JsonRequestBehavior.AllowGet);
            }
        }
    }
}