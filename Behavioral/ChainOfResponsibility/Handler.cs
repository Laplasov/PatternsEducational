using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.ChainOfResponsibility
{
    internal class Handler : IHandler
    {
        private IHandler? m_handler;
        public IHandler SetNext(IHandler next) =>m_handler = next;
        public virtual string Handle(string massage) => m_handler?.Handle(massage) ?? massage;
    }
}
