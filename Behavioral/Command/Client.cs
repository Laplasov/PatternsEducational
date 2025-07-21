using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Command
{
    internal class Client
    {
        public Client() 
        {
            Receiver receiver = new();
            Invoker invoker = new();

            Console.WriteLine("Test commands:");

            invoker.Execute(new ConcreteCommandA(receiver));
            invoker.Execute(new ConcreteCommandB(receiver));
            invoker.Execute(new ConcreteCommandC(receiver));

            invoker.Undo();
            invoker.Undo();
            invoker.Undo();

        }
    }
}
