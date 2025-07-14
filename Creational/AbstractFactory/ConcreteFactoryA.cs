using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    internal class ConcreteFactoryA: IAbstractFactory
    {
        public IAbstractProduct CreateProductA()
        {
            return new ConcreteProductA("AbstractProduct_A_1");
        }
        public IAbstractProduct CreateProductB()
        {
            return new ConcreteProductB("AbstractProduct_B_1");
        }
    }
}
