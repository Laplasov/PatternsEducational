using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.ChainOfResponsibility
{
    internal class ConcreteHandlerC : Handler
    {
        public override string Handle(string massage)
        {
            Console.WriteLine("Responsibility C added!");

            return base.Handle(massage + " + C");
        }
    }
}
