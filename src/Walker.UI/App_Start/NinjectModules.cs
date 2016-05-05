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
                return new[] { new MainModule() };
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
    }
}
