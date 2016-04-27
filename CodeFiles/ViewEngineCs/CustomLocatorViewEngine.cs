using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.CodeFiles.ViewEngineCs
{
    public class CustomLocatorViewEngine : RazorViewEngine
    {
        public CustomLocatorViewEngine()
        {
            ViewLocationFormats = new string[] { "~/Views/{1}/{0}.cshtml", "~/Views/Common/{0}.cshtml" };
        }
    }
}