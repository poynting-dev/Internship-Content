using MVCFiltersDemo.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCFiltersDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //Adding Handle Error attribute Globally
            //GlobalFilters.Filters.Add(new HandleErrorAttribute());
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
