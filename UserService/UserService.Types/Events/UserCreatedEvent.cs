using JacksFramework.Service;
using System;

namespace UserService.Types.Events
{
	public interface UserCreatedEvent : IEventMessage
	{
		Guid UserId { get; set; }
	}
}
