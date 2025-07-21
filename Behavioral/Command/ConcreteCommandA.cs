using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Command
{
    internal class ConcreteCommandA : ICommand
    {
        private readonly Receiver m_receiver;
        public ConcreteCommandA(Receiver receiver) =>
            m_receiver = receiver;

        public void Execute() => m_receiver.Add("Command A added!");
        public void Undo() => m_receiver.Add("Command A removed!");
    }
}
