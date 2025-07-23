using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Mediator
{
    internal interface IColleague
    {
        public void HandleMessage(string message, IColleague sender);
        public void SendMessage(string message);
    }
}
