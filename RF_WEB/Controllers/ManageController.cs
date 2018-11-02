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
        [HttpPost]
        public JsonResult Menu()
        {
            return Json("{\"codes\":\"121313\"}");
        }
    }
}