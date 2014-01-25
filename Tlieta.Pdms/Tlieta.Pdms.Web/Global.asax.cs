using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Tlieta.Pdms.Web.Controllers;

namespace Tlieta.Pdms.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new SessionOutHandler());
            filters.Add(new System.Web.Mvc.AuthorizeAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_Error(object sender, EventArgs e)
        {

            var httpContext = ((MvcApplication)sender).Context;
            var currentRouteData = RouteTable.Routes.GetRouteData(new HttpContextWrapper(httpContext));
            Logging.LogError(httpContext.Error);
            try
            {
                var currentController = " ";
                var currentAction = " ";

                if (currentRouteData != null)
                {
                    if (currentRouteData.Values["controller"] != null && !String.IsNullOrEmpty(currentRouteData.Values["controller"].ToString()))
                    {
                        currentController = currentRouteData.Values["controller"].ToString();
                    }

                    if (currentRouteData.Values["action"] != null && !String.IsNullOrEmpty(currentRouteData.Values["action"].ToString()))
                    {
                        currentAction = currentRouteData.Values["action"].ToString();
                    }
                }

                //if (currentController.ToLower() != "home" && currentController.ToLower() != "favicon.ico")
                if (currentController.ToLower() != "favicon.ico")
                {
                    var ex = Server.GetLastError();
                    var controller = new ErrorController();
                    var routeData = new RouteData();
                    var action = "Error";

                    if (ex is HttpException)
                    {
                        var httpEx = ex as HttpException;

                        switch (httpEx.GetHttpCode())
                        {
                            case 404:
                                action = "SessionTimeout";
                                routeData.Values["controller"] = "Home";
                                break;

                            case 401:
                                action = "Error";
                                routeData.Values["controller"] = "Error";
                                break;
                        }
                    }

                    httpContext.ClearError();
                    httpContext.Response.Clear();
                    httpContext.Response.StatusCode = ex is HttpException ? ((HttpException)ex).GetHttpCode() : 500;
                    httpContext.Response.TrySkipIisCustomErrors = true;

                    routeData.Values["action"] = action;

                    controller.ViewData.Model = new HandleErrorInfo(ex, currentController, currentAction);
                    ((IController)controller).Execute(new RequestContext(new HttpContextWrapper(httpContext), routeData));
                }
            }
            catch
            {
            }
        }
    }
}