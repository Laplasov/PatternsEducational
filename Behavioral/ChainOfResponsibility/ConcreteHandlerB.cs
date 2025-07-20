using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.ChainOfResponsibility
{
    internal class ConcreteHandlerB : Handler
    {
        public override string Handle(string massage)
        {
            Console.WriteLine("Responsibility B added!");

            return base.Handle(massage + " + B");
        }
    }
}
