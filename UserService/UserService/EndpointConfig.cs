using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using JacksFramework.Service.Configuration;

namespace UserService
{
	public class EndpointConfig : IConfigureThisEndpoint, AsA_Publisher, IWantCustomInitialization
	{
		public void Init()
		{
			var container = BootStrapper.BootStrapDependencies();

			NsbBootstrapper.InitializeDefaultXmlForHost(container);
		}
	}
}
