using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using NServiceBus;

using JacksFramework.Infrastructure.WebStructure;

namespace JacksFramework.Extensions.NServiceBus
{
	public static class ConfigurererExtensions
	{
		/// <summary>
		/// Configures MVC (v4)
		/// </summary>
		/// <param name="configure"></param>
		/// <returns></returns>
		public static Configure ForMvc(this Configure configure)
		{
			configure.Configurer.RegisterSingleton(typeof(IControllerActivator), new ControllerActivator());

			var controllers = Configure.TypesToScan.Where(x => typeof(IControllerActivator).IsAssignableFrom(x));

			foreach(Type type in controllers)
			{
				configure.Configurer.ConfigureComponent(type, DependencyLifecycle.InstancePerCall);
			}

			return configure;
		}
	}
}
