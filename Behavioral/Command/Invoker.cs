using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Command
{
    internal class Invoker
    {
        private readonly Stack<ICommand> m_stack = new();

        public void Execute(ICommand cmd)
        {
            cmd.Execute();
            m_stack.Push(cmd);
        }
        public void Undo()
        {
            if (m_stack.TryPop(out var cmd))
                cmd.Undo();
        }

    }
}
