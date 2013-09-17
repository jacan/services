using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace JacksFramework.Service.Endpoints
{
    public abstract class ServiceHandler : IHandleMessages<EventBase>
    {

        public void Handle(EventBase message)
        {
            throw new NotImplementedException();
        }
    }
}
