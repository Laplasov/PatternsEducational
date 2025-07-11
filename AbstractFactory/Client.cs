using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    internal class Client
    {
        public IAbstractFactory CreateFactory(string Name)
        {
            switch (Name)
            {
                case "A":
                    return new ConcreteFactoryA();
                case "B":
                    return new ConcreteFactoryB();
                default: 
                    throw new ArgumentException("Not existing factory!");
            }
        }
    }
}
