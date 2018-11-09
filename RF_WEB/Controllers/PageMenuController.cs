using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RF_WEB.Controllers
{
    public class PageMenuController : Controller
    {
        // GET: PageMenu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetMenu()
        {
            var model = new List<Models.PageMenu>() {
                new Models.PageMenu(){ Name = "减免记录", Url="/Manage/ReliefView" },
                new Models.PageMenu(){ Name = "减免管理", Url="/Manage/ReliefManage" }
            };
            return PartialView("~/Views/Shared/_menu.cshtml", model);
        }
    }
}