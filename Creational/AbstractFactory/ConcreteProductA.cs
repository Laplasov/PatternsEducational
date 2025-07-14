using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    public class ConcreteProductA : IAbstractProduct
    {
        public string Name { get; set; }
        public ConcreteProductA(string name) => Name = name;
    }
}
