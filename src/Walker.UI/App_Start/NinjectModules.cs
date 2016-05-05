using Ninject.Modules;

namespace Walker.UI.Ninject
{
    public class NinjectModules
    {
        //Return Lists of Modules in the Application
        public static NinjectModule[] Modules
        {
            get
            {
                //Return Modules to use for DI
                return new NinjectModule[] { new MainModule(), new MvcControllerModule(), new ApiControllerModule() };
            }
        }

        //Main Module For Application. 
        public class MainModule : NinjectModule
        {
            public override void Load()
            {
                //TODO: Bind to Concrete Types Here
            }
        }

        public class MvcControllerModule : NinjectModule
        {
            public override void Load()
            {
                //TODO: Bind the MVC controllers

            }
        }

        public class ApiControllerModule : NinjectModule
        {
            public override void Load()
            {
                //TODO: Bind the API controllers

            }
        }

    }
}
