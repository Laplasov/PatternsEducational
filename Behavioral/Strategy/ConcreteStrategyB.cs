using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Strategy
{
    internal class ConcreteStrategyB : IStrategy
    {
        public void Execute(string message) => Console.WriteLine($"ConcreteStrategyB get message - {message}");
    }
}
