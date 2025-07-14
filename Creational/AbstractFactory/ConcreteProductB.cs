using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    internal class ConcreteProductB : IAbstractProduct
    {
        public string Name { get; set; }
        public ConcreteProductB(string name) => Name = name;
    }
}
