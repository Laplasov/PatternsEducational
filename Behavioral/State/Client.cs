using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.State
{
    internal class Client
    {
        public Client() 
        {
            var context = new Context();

            for (var i = 0; i < 4; i++)
            {
                context.StateInfo();
                context.SetState();
            }
        }
    }
}
