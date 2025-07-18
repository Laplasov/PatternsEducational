using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Facade
{
    internal class Client
    {
        public Client() 
        {
            Console.WriteLine(new Facade().Execute("Client"));
        }
    }
}
