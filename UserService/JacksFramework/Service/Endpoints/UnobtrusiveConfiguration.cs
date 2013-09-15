using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace JacksFramework.Service.Endpoints
{
    public class UnobtrusiveConfiguration : IWantToRunBeforeConfiguration
    {
        public void Init()
        {
            Configure.Instance
                .DefiningCommandsAs(t => t.Namespace != null
                    && t.Namespace.EndsWith("Commands"))
                .DefiningEventsAs(t => t.Namespace != null
                    && t.Namespace.EndsWith("Events"))
                .DefiningMessagesAs(t => t.Namespace != null
                    && t.Namespace.EndsWith("Messages"));
        }
    }
}
