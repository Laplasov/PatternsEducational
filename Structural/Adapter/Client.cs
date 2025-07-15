using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Adapter
{
    internal class Client
    {
        public Client()
        {
            Console.WriteLine("Test Adapters:");
            Console.WriteLine(new Adapter().Executor(AdapterType.TypeA));
            Console.WriteLine(new Adapter().Executor(AdapterType.TypeB));

        }
    }
}
