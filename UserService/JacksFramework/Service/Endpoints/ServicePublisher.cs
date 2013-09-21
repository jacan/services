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

		public void Publish(IEvent eventMessage)
		{
			_bus.Publish(eventMessage);
		}
	}
}
