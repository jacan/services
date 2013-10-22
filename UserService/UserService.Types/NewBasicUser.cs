using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Types
{
	public interface IBasicUser
	{
		string Username { get; set; }
		string Email { get; set; }
	}

	public class NewBasicUser
	{
		public string Username { get; set; }
		public string Email { get; set; }
	}
}
