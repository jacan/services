using JacksFramework.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Types.Commands
{
	[Serializable]
	public class CreateUserCommand : ICommandMessage
	{
		public CreateUserCommand(DateTime timeStamp)
		{
			Timestamp = Timestamp;
		}

		public DateTime? Timestamp
		{
			get;
			set;
		}

		public string UsernameDesired
		{
			get;
			set;
		}

		public string EmailAddress
		{
			get;
			set;
		}
	}
}
