using System;

namespace JacksFramework.Service.Endpoints
{
	public class MessageIdInvalidException : Exception
	{
		public MessageIdInvalidException()
			: base("Message Id must be set, in order to send it on the bus!")
		{
			
		}
	}
}
