using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace JacksFramework.Service.Endpoints
{
    public class ServiceSubscriber : IConfigureThisEndpoint, AsA_Server, IWantCustomInitialization
    {
        public void Init()
        {
            Configure.With()
                .DefaultBuilder(); // <= Currently Spring, change to StructureMap
        }
    }
}
