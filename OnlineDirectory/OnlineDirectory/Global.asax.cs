using Autofac;
using Autofac.Integration.Mvc;
using OnlineDirectory.BLL;
using OnlineDirectory.DAL;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace OnlineDirectory
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType(typeof(ContactService)).AsImplementedInterfaces();
            builder.RegisterType(typeof(ContactRepository)).AsImplementedInterfaces();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
