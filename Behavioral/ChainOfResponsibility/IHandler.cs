using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.ChainOfResponsibility
{
    internal interface IHandler
    {
        public IHandler SetNext(IHandler next);
        public string Handle(string massage);
    }
}
