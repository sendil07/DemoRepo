using System.Web;
using System.Web.Mvc;

namespace MusicStore.CodeFiles.ViewEngineCs
{
    public class CustomAuthAttribute : AuthorizeAttribute
    {
        private bool blnIsAllowed;
        public CustomAuthAttribute(bool IsLocal)
        {
            blnIsAllowed = IsLocal;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Request.IsLocal)
            {
                return blnIsAllowed;
            }
            else
            {
                return true;
            }
        }
    }

    //public class MYClass :Controller
}