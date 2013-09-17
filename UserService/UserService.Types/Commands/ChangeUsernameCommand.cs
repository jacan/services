using JacksFramework.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Types.Commands
{
    public class ChangeUsernameCommand : CommandBase
    {
        public Guid UserId { get; set; }
        
        public string UserName { get; set; }
        public string NewUserNameRequested { get; set; }
    }
}
