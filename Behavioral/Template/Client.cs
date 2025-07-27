using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Template
{
    internal class Client
    {
        public Client() 
        {
            AbstractClass abstractClassA = new ConcreteClassA();
            abstractClassA.TemplateMethod();

            AbstractClass abstractClassB = new ConcreteClassB();
            abstractClassB.TemplateMethod();
        }
    }
}
