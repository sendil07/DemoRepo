using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace MusicStore.CodeFiles.ViewEngineCs
{
    public class DebugDataView : IView
    {
        public void Render(ViewContext objViewContext, TextWriter objTextWriter)
        {
            objTextWriter.Write("--------Routing Data -------");
            foreach (string strKey in objViewContext.RouteData.Values.Keys)
            {
                objTextWriter.Write("Key: {0}, Value:{1}", strKey, objViewContext.RouteData.Values[strKey]);
            }

            Write(objTextWriter, "---View Data---");
            foreach (string key in objViewContext.ViewData.Keys)
            {
                Write(objTextWriter, "Key: {0}, Value: {1}", key,
                objViewContext.ViewData[key]);
            }
        }

        private void Write(TextWriter writer, string template, params object[] values)
        {
            writer.Write(string.Format(template, values) + "<p/>");
        }
    }
}