using JacksFramework.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Types.Commands
{
    public class CreateUserCommand<T> where T : IBasicUser
    {
        // Make T2, maybe so that command n can call n->Send(this);
        T User { get; set; }
    }
}
