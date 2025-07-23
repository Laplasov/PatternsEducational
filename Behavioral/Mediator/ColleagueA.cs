using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patterns.Behavioral.Mediator
{
    internal class ColleagueA : IColleague
    {
        public ColleagueA(IMediator concreteMediator, string name)
        {
            _concreteMediator = concreteMediator;
            Name = name;
        }
        private IMediator _concreteMediator { get; set; }
        public string Name { get; set; } = "ColleagueA";

        public void HandleMessage(string message, IColleague sender)
        {
            if (sender != this) 
                Console.WriteLine($"{Name} received:\n{message}");
        }

        public void SendMessage(string message) => _concreteMediator.SendMessage($"Request from {Name} to send message:\n" + message, this);

    }
}
