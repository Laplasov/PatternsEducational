using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Decorator
{
    internal class Client
    {
        public Client() 
        {
            Console.WriteLine("rawComponent:");

            IComponent rawComponent = new ConcreteComponen("Test\n");
            Console.WriteLine(rawComponent.GetText());

            IComponent decoratorA = new ConcreteDecoratorA(rawComponent);
            IComponent decoratorB = new ConcreteDecoratorB(rawComponent);

            Console.WriteLine("decoratorA:");
            Console.WriteLine(decoratorA.GetText());

            Console.WriteLine("decoratorB:");
            Console.WriteLine(decoratorB.GetText());
        }
    }
}
