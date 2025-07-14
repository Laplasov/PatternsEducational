using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{

    enum PrototypeType { TypeA, TypeB }

    internal class Client
    {
        public Client() 
        {
            Console.WriteLine("Testing Prototype A:");

            var PrototypeA = new ConcretePrototypeA("Tomas", 213);
            var cloneA = PrototypeA.Clone();

            Console.WriteLine($"Original: {PrototypeA.GetString()}");
            Console.WriteLine($"Clone: {cloneA.GetString()}");
            Console.WriteLine($"Reference equals: {ReferenceEquals(PrototypeA, cloneA)}\n");

            Console.WriteLine("Testing Prototype B:");

            var PrototypeB = new ConcretePrototypeB("Tomas", true);
            var cloneB = PrototypeB.Clone();

            Console.WriteLine($"Original: {PrototypeB.GetString()}");
            Console.WriteLine($"Clone: {cloneB.GetString()}");
            Console.WriteLine($"Reference equals: {ReferenceEquals(PrototypeB, cloneB)}\n");
        }
    }


}
