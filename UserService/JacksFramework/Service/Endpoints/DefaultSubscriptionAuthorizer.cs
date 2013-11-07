﻿using NServiceBus;
using System.Collections.Generic;

namespace JacksFramework.Service.Endpoints
{
	public class DefaultSubscriptionAuthorizer : IAuthorizeSubscriptions
	{
		public bool AuthorizeSubscribe(string messageType, string clientEndpoint, IDictionary<string, string> headers)
		{
			return true;
		}

		public bool AuthorizeUnsubscribe(string messageType, string clientEndpoint, IDictionary<string, string> headers)
		{
			return true;
		}
	}
}
