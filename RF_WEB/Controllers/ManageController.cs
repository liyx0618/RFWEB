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
            return View("~/Views/Manage/ReliefRecord.cshtml");
        }
        [HttpPost]
        public JsonResult Menu()
        {
            return Json("{\"codes\":\"121313\"}");
        }

        public ActionResult ReliefRecord()
        {
            List<Models.CarCodeReliefRecords> list = new List<Models.CarCodeReliefRecords>();
            list.Add(new Models.CarCodeReliefRecords() { CarCode="浙A12345", InTime= DateTime.Now, RecordID=1, ChannelID =1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12346", InTime = DateTime.Now, RecordID = 2, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12347", InTime = DateTime.Now, RecordID = 3, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12348", InTime = DateTime.Now, RecordID = 4, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12349", InTime = DateTime.Now, RecordID = 5, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A123410", InTime = DateTime.Now, RecordID = 6, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12345", InTime = DateTime.Now, RecordID = 1, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12346", InTime = DateTime.Now, RecordID = 2, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12347", InTime = DateTime.Now, RecordID = 3, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12348", InTime = DateTime.Now, RecordID = 4, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12349", InTime = DateTime.Now, RecordID = 5, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A123410", InTime = DateTime.Now, RecordID = 6, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12345", InTime = DateTime.Now, RecordID = 1, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12346", InTime = DateTime.Now, RecordID = 2, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12347", InTime = DateTime.Now, RecordID = 3, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12348", InTime = DateTime.Now, RecordID = 4, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12349", InTime = DateTime.Now, RecordID = 5, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A123410", InTime = DateTime.Now, RecordID = 6, ChannelID = 1 });
            return View("~/Views/Manage/ReliefRecord.cshtml", list);
        }

        //[HttpPost]
        public JsonResult Reliefs(Models.DataTableParameter parameter)//(string strname, int sEcho, int iDisplayStart, int iDisplayLength)
        {
            List<Models.CarCodeReliefRecords> list = new List<Models.CarCodeReliefRecords>();
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12341", InTime = DateTime.Now, RecordID = 1, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12342", InTime = DateTime.Now, RecordID = 2, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12343", InTime = DateTime.Now, RecordID = 3, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12344", InTime = DateTime.Now, RecordID = 4, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12345", InTime = DateTime.Now, RecordID = 5, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12346", InTime = DateTime.Now, RecordID = 6, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12347", InTime = DateTime.Now, RecordID = 7, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12348", InTime = DateTime.Now, RecordID = 8, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12349", InTime = DateTime.Now, RecordID = 9, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12310", InTime = DateTime.Now, RecordID = 10, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12311", InTime = DateTime.Now, RecordID = 11, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12312", InTime = DateTime.Now, RecordID = 12, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12313", InTime = DateTime.Now, RecordID = 13, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12314", InTime = DateTime.Now, RecordID = 14, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12315", InTime = DateTime.Now, RecordID = 15, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12316", InTime = DateTime.Now, RecordID = 16, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12317", InTime = DateTime.Now, RecordID = 17, ChannelID = 1 });
            list.Add(new Models.CarCodeReliefRecords() { CarCode = "浙A12318", InTime = DateTime.Now, RecordID = 18, ChannelID = 1 });

            var listd = list.Skip(parameter.iDisplayStart).Take(parameter.iDisplayLength);

            //return Json(list);
            return Json(new
            {
                draw = parameter.sEcho,
                recordsFiltered = 15,
                recordsTotal = 15,
                data = listd
            }, JsonRequestBehavior.AllowGet);
        }
    }
}