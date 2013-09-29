using NServiceBus;
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
			_commands.Add(command);
		}

		public void Distribute()
		{
			_bus.Send(_commands);
		}
	}
}
