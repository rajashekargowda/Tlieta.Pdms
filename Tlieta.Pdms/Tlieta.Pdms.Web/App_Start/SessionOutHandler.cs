using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Tlieta.Pdms.Web
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class SessionOutHandler : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName.ToLower();
            string actionName = filterContext.ActionDescriptor.ActionName.ToLower();

            if (! controllerName.Contains("error"))
            {
                if (!controllerName.Contains("home"))
                {
                    ValidateSession(filterContext);
                }
                else {
                    if (actionName == "entry" || actionName == "changepassword")
                    {
                        ValidateSession(filterContext);
                    }
                }
            }
        }

        private void ValidateSession(ActionExecutingContext filterContext)
        {
            HttpSessionStateBase session = filterContext.HttpContext.Session;
            //session["userid"] = null;
            var user = session["userid"];
            if (((user == null) && (!session.IsNewSession)) || (session.IsNewSession))
            {
                //send them off to the login page
                var url = new UrlHelper(filterContext.RequestContext);
                var sessionoutUrl = url.Content("~/Home/SessionTimeout");
                filterContext.HttpContext.Response.Redirect(sessionoutUrl, true);
            }
        }
    }
}