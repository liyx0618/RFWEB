using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RF_WEB.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("~/Views/Login/Index.cshtml");
        }

        public ActionResult login()
        {
            return View("~/Views/Manage/Index.cshtml");
        }

        public JsonResult CheckLogin(string username, string password, string code)
        {
            return Json(new Utils.AjaxResult { state = Utils.ResultType.success.ToString(), message = "登录成功。" });
            //return Content(json);
        }

        public ActionResult GetAuthCode()
        {
            return File(new Utils.VerifyCode().GetVerifyCode(), @"image/Gif");
        }
    }
}