using System;
using JacksFramework.Extensions.NServiceBus;
using NServiceBus;
using StructureMap;

namespace JacksFramework.Service.Configuration
{
	public class NsbBootstrapper
	{
		/// <summary>
		/// Initializes default NServiceBus with Transaction, binary serialization on MSMQ transport, StructureMap container
		/// </summary>
		public static void InitializeDefaultXmlForHost(IContainer container=null)
		{
			Configure.Transactions.Enable();
			Configure.Serialization.Xml();

			Configure.With()
					 .StructureMapBuilder(container)
					 .Log4Net()
					 .UseTransport<Msmq>()
					 .PurgeOnStartup(false)
					 .UnicastBus();
		}

		public static IBus InitializeWebDefaultXml(IContainer container=null)
		{
			Configure.Transactions.Enable();
			Configure.Serialization.Xml();

			return Configure.With()
					 .StructureMapBuilder(container)
					 .ForMvc()
					 .Log4Net()
					 .UseTransport<Msmq>()
					 .PurgeOnStartup(false)
					 .UnicastBus()
					 .ImpersonateSender(false)
					 .CreateBus()
					 .Start();
		}

		public IBus InitializeWebDefaultJSON(IContainer container=null)
		{
			Configure.Transactions.Enable();
			Configure.Serialization.Json();

			return Configure.With()
					 .StructureMapBuilder(container)
					 .ForMvc()
					 .Log4Net()
					 .UseTransport<Msmq>()
					 .PurgeOnStartup(false)
					 .UnicastBus()
					 .ImpersonateSender(false)
					 .CreateBus()
					 .Start();
		}
	}
}
