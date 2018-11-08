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

        [HttpPost]
        public ActionResult GetMenu()
        {
            var model = new List<Models.PageMenu>() {
                new Models.PageMenu(){ Name = "baidu", Url="/Manage/Index" },
                new Models.PageMenu(){ Name = "baidu2", Url="www.baidu.com" }
            };
            return PartialView("/Views/Shared/_menu.cshtml", model);
        }
    }
}