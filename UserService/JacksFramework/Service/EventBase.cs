using System;
using NServiceBus;

namespace JacksFramework.Service
{
    public abstract class EventBase : IEvent
    {
        public Guid Id { get; set; }
    }
}
