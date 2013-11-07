using StructureMap;

namespace UserService
{
	public class BootStrapper
	{
		public static IContainer BootStrapDependencies()
		{
			var serviceContainer = new Container(container => {
				container.AddRegistry<ServiceRegistry>();
			});

			return serviceContainer;
		}
	}
}
