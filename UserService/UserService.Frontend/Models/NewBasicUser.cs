using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserService.Frontend.Models
{
	public class NewBasicUser
	{
		[Required(ErrorMessage = "Username must be filled")]
		[StringLength(500, ErrorMessage = "Your username is too long")]
		[Display(Name = "Username wanted")]
		public string DesiredUsername
		{
			get;
			set;
		}

		[Required(ErrorMessage = "A email must be provided")]
		[StringLength(254, ErrorMessage = "Your email address is not valid")]
		[EmailAddress]
		[Display(Name = "E-Mail address")]
		public string MailForVerification
		{
			get;
			set;
		}
	}
}