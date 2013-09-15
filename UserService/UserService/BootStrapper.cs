using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService
{
    public class BootStrapper
    {
        public void BootStrapDependencies()
        {
            ObjectFactory.Initialize(x =>
            {
                x.Scan(scan => {
                        scan.TheCallingAssembly();
                        scan.Assembly("UserService.Types");
                        scan.WithDefaultConventions();                        
                });                               
            });
        }
    }
}
