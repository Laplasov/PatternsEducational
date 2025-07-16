using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Bridge
{
    internal class Client
    {
        public Client() 
        {
            Abstraction abstraction = new RefinedAbstraction(new ConcreteImplementorA());
            abstraction.Log("Hello 1.");
            abstraction.SetType(ImpType.TypeB);
            abstraction.Log("Hello 2.");
        }
    }
}
