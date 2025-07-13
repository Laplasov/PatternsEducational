using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    internal class ConcreteCreatorA : Creator
    {
        public override Product CreateProduct(string name) => new ConcreteProductA(name);
    }
}
