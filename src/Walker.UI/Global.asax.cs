using System.Web.Mvc;
using System.Web.Routing;

using Walker.UI.Ninject;

namespace Walker.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            NinjectContainer.RegisterModules(NinjectModules.Modules);
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
