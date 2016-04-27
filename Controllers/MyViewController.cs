using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class MyViewController : Controller
    {
        //
        // GET: /MyView/

        public ActionResult Index()
        {
            ViewBag.Message = "My first view engine";
            return View("DebugData");
        }

        public ActionResult List()
        {

            return View("", "", null);
        }

        public ActionResult SectionSample()
        {
            string[] names = { "Apple", "Orange", "Pear" };
            return View(names);
        }

        [ChildActionOnly]
        public ActionResult Time()
        {
            return PartialView(DateTime.Now);
        }
    }
}
