using NServiceBus;
using System;

namespace JacksFramework.Service
{
    public interface IMessageBase
    {
        Guid MessageId { get; set; }
        DateTime Timestamp { get; set; }
    }

    public class MessageBase : IMessageBase
    {
        public Guid MessageId
        {
            get;
            set;
        }

        public DateTime Timestamp
        {
            get;
            set;
        }
    }
}
