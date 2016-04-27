using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.CodeFiles.ViewEngineCs
{
    public class DebugDataViewEngine : IViewEngine
    {
        public ViewEngineResult FindView(ControllerContext objCContext, string strViewName, string strMasterName, bool blnIsCached)
        {
            if (strViewName == "DebugData")
                return new ViewEngineResult(new DebugDataView(), this);
            else
                return new ViewEngineResult(new string[] { "No view (Debug Data View Engine)" });
        }

        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            return new ViewEngineResult(new string[] { "No view (Debug Data View Engine)" });
        }
        public void ReleaseView(ControllerContext controllerContext, IView view)
        {
            // do nothing
        }
    }
}