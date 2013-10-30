using System;
using System.Web.Mvc;

namespace JacksFramework.Infrastructure.WebStructure
{
	public class ControllerActivator : IControllerActivator
	{
		public IController Create(System.Web.Routing.RequestContext requestContext, Type controllerType)
		{
			return DependencyResolver.Current.GetService(controllerType) as IController;
		}
	}
}
