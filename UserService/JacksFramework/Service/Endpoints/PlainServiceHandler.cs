using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace JacksFramework.Service.Endpoints
{
	public abstract class PlainServiceHandler : IHandleMessages<IEventMessage>
	{
		private readonly IEnumerable<IMessageHandleSink> _messageSinks;

		public PlainServiceHandler(IEnumerable<IMessageHandleSink> messageSinks)
		{
			_messageSinks = messageSinks;
		}

		public void Handle(IEventMessage message)
		{
			_messageSinks.AsParallel()
				.ForAll(x => x.Handle(message));
		}
	}
}
