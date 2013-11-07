using JacksFramework.Repositories;
using RavenStore;
using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Store;

namespace UserService
{
	public class ServiceRegistry : Registry
	{
		public ServiceRegistry()
		{
			For<IRepositoryContext>().Use<RavenContext>().Ctor<string>("connectionString").Is(ConfigurationManager.ConnectionStrings["RavenConnection"].ConnectionString);
			For<IUserRepository>().Use<UserRepository>();
			Scan(x => x.TheCallingAssembly());
		}
	}
}
