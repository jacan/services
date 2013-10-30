using JacksFramework.Service;
using System;

namespace UserService.Types.Commands
{
	public class ChangeUsernameCommand : IUserCommand
	{
		public Guid Id { get; set; }
		public DateTime? Timestamp { get; set; }
		
		public Guid UserId { get; set; }
		public string UserName { get; set; }
		public string NewUserNameRequested { get; set; }
	}
}
