using System;

namespace UserService.Types.Events
{
	public interface UserCreatedEvent
	{
		Guid UserId { get; set; }
	}
}
