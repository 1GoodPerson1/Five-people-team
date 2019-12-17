using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LBH_EF_DAL;
using Newtonsoft.Json;
using System.IO;
using HPIT.Data.Core;
using LBH_WebApp.Controllers;
using LBH_WebApp.filer;

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
        [Authorize]
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
        [AllowAnonymous]
        [HttpPost]
        public ActionResult ProcessUploadFiles(IEnumerable<HttpPostedFileBase> filenames)
        {
            foreach (var file in filenames)
            {
                var filename = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Upload"), filename);
                file.SaveAs(path);
            }
            return RedirectToAction("FileListIndex");
        }
        [AllowAnonymous]
        public ActionResult fileInputIndex()
        {
            return View();
        }
        [AllowAnonymous]
        public FileResult download(string filename)
        {
            string filePath = Server.MapPath("~/Upload/" + filename);
            return File(filePath, "text/plain", filename);
        }
        [AllowAnonymous]
        public JsonResult GetFileList(SearchModel<FileModel> search)
        {
            int total = 0;
            string filePath = Server.MapPath("~/Upload/");
            DirectoryInfo directoryInfo = new DirectoryInfo(filePath);
            FileInfo[] allfiles = directoryInfo.GetFiles();
            var data = from file in allfiles
                       select new
                       {
                           filename = file.Name,
                           path = file.DirectoryName,
                           time = file.LastWriteTime,
                           fullname = file.FullName
                       };
            total = allfiles.Length;
            var totalPages = total % search.PageSize == 0 ? total / search.PageSize : total / search.PageSize + 1;
            JsonResult result = new JsonResult();
            var pagedata = data.Skip((search.PageIndex - 1) * search.PageSize).Take(search.PageSize);
            result.Data = new { Data = data, Total = total, TotalPages = totalPages };
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return new DeluxeJsonResult(new { Data = pagedata, Total = total, TotalPages = totalPages }, "yyyy-MM-dd HH: mm");
        }
        [AllowAnonymous]
        public ActionResult FileListIndex()
        {
            return View();
        }
    }
}