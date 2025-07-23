using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Mediator
{
    internal class ConcreteMediator : IMediator
    {
        private List<IColleague> m_colleagues = new();
        public event Action<string, IColleague>? TextEvent; 

        public void AddColleague(IColleague colleague)
        {
            m_colleagues.Add(colleague);
            TextEvent += colleague.HandleMessage;
        }

        public void SendMessage(string message, IColleague sender)
        {
            Console.WriteLine($"Mediator broadcasting:\n{message}");
            TextEvent?.Invoke(message, sender);
        }

        public void RemoveColleague(IColleague colleague)
        {
            m_colleagues.Remove(colleague);
            TextEvent -= colleague.HandleMessage;
        }
    }
}
