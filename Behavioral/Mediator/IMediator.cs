using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Mediator
{
    internal interface IMediator
    {
        public void AddColleague(IColleague colleague);
        public void SendMessage(string message, IColleague sender);
        public void RemoveColleague(IColleague colleague);
    }
}
