using JacksFramework.Service.Endpoints;
using NServiceBus;
using System;
using System.Collections.Concurrent;

namespace JacksFramework.Service
{
	public interface IDistrubute
	{
		void Add(IMessageBase command);
		void Distribute();
	}

	public class CommandDistributor : IDistrubute
	{
		protected ConcurrentBag<IMessageBase> _commands;
		protected IBus _bus;

		public CommandDistributor(IBus bus)
		{
			_bus = bus;
		}

		public CommandDistributor()
		{
			_commands = new ConcurrentBag<IMessageBase>();
		}

		public void Add(IMessageBase command)
		{
			if (command.Id.Equals(Guid.Empty) || command.Timestamp == null)
			{
				throw new MessageIdInvalidException();
			}

			if (command.Timestamp == null)
			{
				throw new MessageTimestampInvalidException();
			}

			_commands.Add(command);
		}

		public void Distribute()
		{
			_bus.Send(_commands);
		}
	}
}
