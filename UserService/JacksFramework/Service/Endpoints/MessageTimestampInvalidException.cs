using System;

namespace JacksFramework.Service.Endpoints
{
	public class MessageTimestampInvalidException : Exception
	{
		public MessageTimestampInvalidException()
			: base("Message timestamp must be set in order to send it on the bus!")
		{
			
		}
	}
}
