using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using UserService.Types.Commands;
using UserService.Store;
using UserService.Types;
using UserService.Types.Events;

namespace UserService
{
	public class CreateUserHandler : IHandleMessages<CreateUserCommand>
	{
		private IBus _bus;
		private IUserRepository _userRepository;

		public CreateUserHandler(IBus bus, IUserRepository userRepository)
		{
			_bus = bus;
			_userRepository = userRepository;
		}

		public void Handle(CreateUserCommand message)
		{
			var createdUserId = _userRepository.CreateUser(message.UsernameDesired, message.EmailAddress);

			_bus.Publish<UserCreatedEvent>(userCreatedEvent =>  
				userCreatedEvent.UserId = createdUserId
				);
		}
	}
}
