using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Types.Events
{
    public class UserCreatedEvent
    {
        Guid UserId { get; set; }
    }
}
