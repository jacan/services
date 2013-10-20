using NServiceBus;

namespace JacksFramework.Service
{
	public interface ICommandMessage : ICommand, IMessageBase
	{

	}
}
