using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.CodeFiles.ViewEngineCs;

namespace MusicStore.Controllers
{
    public class DerivedController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello from the DerivedController Index method";
            return Redirect("~/Home/Index");
        }

        public ActionResult ProduceOutput(string strInput)
        {
            if (strInput == "TINY")
            {
                return new CustomRedirectResult { Url = "Home/Index" };
            }
            else
            {
                Response.Write("Controller: Derived, Action: ProduceOutput");
                return null;
            }
        }

    }
}
