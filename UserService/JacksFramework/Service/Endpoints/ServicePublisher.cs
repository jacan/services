using NServiceBus;

namespace JacksFramework.Service.Endpoints
{
	public class ServicePublisher : IConfigureThisEndpoint, AsA_Publisher
	{
		protected IBus _bus;

		public ServicePublisher(IBus bus)
		{
			_bus = bus;
		}

		public void Publish(IEventMessage eventMessage)
		{
			_bus.Publish(eventMessage);
		}
	}
}
