using JacksFramework.Infrastructure.WebStructure;
using JacksFramework.Service.Configuration;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using UserService.Types.Events;

namespace UserService.Frontend
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);

			var container = InitializeDependices();

			var bus = NsbBootstrapper.InitializeWebDefaultXml(container);
		}

		protected IContainer InitializeDependices()
		{
			IContainer container = new Container();

			DependencyResolver.SetResolver(new StructureMapDependencyResolver(container));

			return container;
		}
	}
}
