using System;
using JacksFramework.Extensions.NServiceBus;
using NServiceBus;

namespace JacksFramework.Service.Configuration
{
	public static class NsbBootstrapper
	{
		/// <summary>
		/// Initializes default NServiceBus with Transaction, binary serialization on MSMQ transport, StructureMap container
		/// </summary>
		public static void InitializeDefaultBinary()
		{
			Configure.Transactions.Enable();
			Configure.Serialization.Binary();

			Configure.With()
					 .StructureMapBuilder()
					 .Log4Net()
					 .UseTransport<Msmq>()
					 .PurgeOnStartup(false)
					 .UnicastBus()
					 .CreateBus()
					 .Start();
		}

		public static void InitializeWebDefaultBinary()
		{
			Configure.Transactions.Enable();
			Configure.Serialization.Binary();

			Configure.With()
					 .StructureMapBuilder()
					 .ForMvc()
					 .Log4Net()
					 .UseTransport<Msmq>()
					 .PurgeOnStartup(false)
					 .UnicastBus()
					 .CreateBus()
					 .Start();
		}

		public static void InitializeWebDefaultJSON()
		{
			Configure.Transactions.Enable();
			Configure.Serialization.Json();

			Configure.With()
					 .StructureMapBuilder()
					 .ForMvc()
					 .Log4Net()
					 .UseTransport<Msmq>()
					 .PurgeOnStartup(false)
					 .UnicastBus()
					 .CreateBus()
					 .Start();
		}
	}
}
