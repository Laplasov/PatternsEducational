using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.ChainOfResponsibility
{
    internal class Client
    {
        public Client() 
        {
            ConcreteHandlerA resA = new();
            ConcreteHandlerB resB = new();
            ConcreteHandlerC resC = new();

            resA.SetNext(resB).SetNext(resC);

            var respons_1 = resA.Handle("Test 1.");

            Console.WriteLine(respons_1);

            resA = new();
            resB = new();
            resC = new();

            resC.SetNext(resB).SetNext(resA);

            var respons_2 = resC.Handle("Test 2.");

            Console.WriteLine(respons_2);
        }
    }
}
