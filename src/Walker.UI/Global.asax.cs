using System.Web.Mvc;
using System.Web.Routing;

using Walker.UI.Ninject;

namespace Walker.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            NinjectContainer.RegisterModules(NinjectModules.Modules);
        }
    }
}
