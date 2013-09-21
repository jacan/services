using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace JacksFramework.Service.Endpoints
{
    public abstract class PlainServiceHandler : IHandleMessages<EventBase>
    {
        private readonly IEnumerable<IMessageHandleSink> _messageSinks;
        
        public PlainServiceHandler(IEnumerable<IMessageHandleSink> messageSinks)
        {
            _messageSinks = messageSinks;
        }

        public void Handle(EventBase message)
        {
            _messageSinks.AsParallel()
                .ForAll(x => x.Handle(message));
        }
    }
}
