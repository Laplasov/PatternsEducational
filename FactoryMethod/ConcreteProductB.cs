using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    internal class ConcreteProductB : Product
    {
        public ConcreteProductB(string name) : base(name) { }
        public override string Render() => $"B production: {Name}\n";
    }
}
