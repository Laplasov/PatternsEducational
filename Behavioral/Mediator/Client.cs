using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Mediator
{
    internal class Client : IColleague
    {
        public Client() 
        {
            var mediator = new ConcreteMediator();
            var colleagueA = new ColleagueA(mediator, "Same");
            var colleagueB = new ColleagueB(mediator, "Bill");
            
            mediator.AddColleague(colleagueA);
            mediator.AddColleague(colleagueB);

            mediator.SendMessage("Direct sender from a mediator.", this);
            Console.WriteLine();

            colleagueA.SendMessage("Hi from Colleague A.");
            Console.WriteLine();

            colleagueB.SendMessage("Hi from Colleague B.");
            Console.WriteLine();

            mediator.RemoveColleague(colleagueA);
            mediator.RemoveColleague(colleagueB);
        }

        public void HandleMessage(string message, IColleague sender) => throw new NotImplementedException();
        public void SendMessage(string message) => throw new NotImplementedException();
    }
}
