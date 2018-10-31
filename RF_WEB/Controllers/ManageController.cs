using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RF_WEB.Controllers
{
    public class ManageController : Controller
    {
        // GET: Manage
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult Menu()
        {
            return Json("{\"code\":\"121313\"}", JsonRequestBehavior.AllowGet);
        }
    }
}