using StructureMap;

namespace UserService
{
	public class BootStrapper
	{
		public static void BootStrapDependencies()
		{
			ObjectFactory.Initialize(x => x.Scan(scan =>
			{
				scan.TheCallingAssembly();
				scan.Assembly("UserService.Types");
				scan.WithDefaultConventions();
			}));
		}
	}
}
