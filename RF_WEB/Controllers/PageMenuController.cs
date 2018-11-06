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

            return PartialView("");
        }
    }
}