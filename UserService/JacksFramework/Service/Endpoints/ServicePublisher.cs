using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace JacksFramework.Service.Publisher
{
    public class ServicePublisher : IConfigureThisEndpoint, AsA_Publisher
    {
        protected IBus _bus;

        public ServicePublisher(IBus bus)
        {
            _bus = bus;
        }

        public void Publish(IMessage message)
        {
            _bus.Publish(message);
        }
    }
}
