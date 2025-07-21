using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Command
{
    internal class ConcreteCommandB : ICommand
    {
        private readonly Receiver m_receiver;
        public ConcreteCommandB(Receiver receiver) =>
            m_receiver = receiver;

        public void Execute() => m_receiver.Add("Command B added!");
        public void Undo() => m_receiver.Add("Command B removed!");
    }
}
