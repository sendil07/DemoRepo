using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
            //return new EmptyResult();
        }

        public void DerivedController(string strPCName)
        {
            if (strPCName == "SENDIL-PC")
            {
                Response.Redirect("~/MyView");
            }
            else
            {
                Response.Write("Controller: Derived, Action: ProduceOutput");
            }
        }

        //[MusicStore.CodeFiles.ViewEngineCs.CustomAuth(true)]
        [Authorize(Users="sendil")]
        public string CustonFilterTest()
        {
            return "This is custom file test action method call";
        }

        public ActionResult WebAPISample()
        {

            return View("SampleWebAPI");
        }
    }
}
