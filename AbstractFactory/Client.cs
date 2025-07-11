using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    public enum FactoryType { A, B, None }
    internal class Client
    {
        public IAbstractFactory CreateFactory(FactoryType Name)
        {
            switch (Name)
            {
                case FactoryType.A:
                    return new ConcreteFactoryA();
                case FactoryType.B:
                    return new ConcreteFactoryB();
                default: 
                    throw new ArgumentException("Not existing factory!");
            }
        }
    }
}
