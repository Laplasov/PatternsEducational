using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    internal class ConcreteProductA : Product
    {
        public ConcreteProductA(string name) : base(name){}
        public override string Render() => $"A production: {Name}\n";
    }
}
