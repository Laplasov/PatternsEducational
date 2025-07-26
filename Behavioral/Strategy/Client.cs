using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Strategy
{
    internal class Client
    {
        public Client() 
        {
            var context = new Context("New message!");

            Console.WriteLine("One unoptimized strategy.");
            context.SetStrategies(new ConcreteStrategyA(), false);
            context.Execute(false);

            Console.WriteLine("One optimized strategy.");
            context.SetStrategies(new ConcreteStrategyC(), true);
            context.Execute(true);

            Console.WriteLine("Both with B sub-strategy added.");
            context.AddSubStrategy(new ConcreteStrategyB(), false);
            context.AddSubStrategy(new ConcreteStrategyB(), true);

            context.Execute(false);
            context.Execute(true);
        }
    }
}
