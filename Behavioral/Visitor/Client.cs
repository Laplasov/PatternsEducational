using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Visitor
{
    internal class Client
    {
        public Client() 
        {
            var elements = new List<IElement>()
            {
                new ElementA(){NameA = "Element A"},
                new ElementB(){NameB = "Element B"}
            };

            var visitorA = new VisitorA();
            var visitorB = new VisitorB();

            Console.WriteLine("Visitor A rotation.");
            elements.ForEach(e => e.Accept(visitorA));

            Console.WriteLine("Visitor B rotation.");
            elements.ForEach(e => e.Accept(visitorB));
        }
    }
}
