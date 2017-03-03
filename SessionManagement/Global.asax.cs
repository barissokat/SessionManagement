using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SessionManagement
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            int onlineUserCount = Convert.ToInt32(Application["OnlineUserCount"]);
            onlineUserCount = onlineUserCount + 1;
            Application["OnlineUserCount"] = onlineUserCount;
        }

        protected void Session_End(object sender, EventArgs e)
        {
            int onlineUserCount = Convert.ToInt32(Application["OnlineUserCount"]);
            onlineUserCount = onlineUserCount - 1;
            Application["OnlineUserCount"] = onlineUserCount;
        }
    }
}
