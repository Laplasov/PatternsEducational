using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    internal class Client
    {
        public Client() 
        {

            Console.WriteLine("Test product A: \n");

            Creator creatorA = new ConcreteCreatorA();
            var productA = creatorA.CreateProduct("File A").Render();
            Console.WriteLine(productA);

            Console.WriteLine("Test product B: \n");

            Creator creatorB = new ConcreteCreatorB();
            var productB = creatorB.CreateProduct("File B").Render();
            Console.WriteLine(productB);

        }
    }
}
