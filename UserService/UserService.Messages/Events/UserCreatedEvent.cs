using JacksFramework.Service;
using System;

namespace UserService.Messages.Events
{
	public interface UserCreatedEvent : IEventMessage
	{
		Guid UserId { get; set; }
	}
}
