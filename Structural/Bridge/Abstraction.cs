using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Bridge
{
    enum ImpType { TypeA, TypeB }
    internal abstract class Abstraction
    {
        protected IImplementor m_implementor;
        protected Abstraction(IImplementor implementor) =>
        m_implementor = implementor;
        public void SetType(ImpType Type)
        {
            switch (Type)
            {
                case ImpType.TypeA:
                    m_implementor = new ConcreteImplementorA();
                    break;
                case ImpType.TypeB:
                    m_implementor = new ConcreteImplementorB();
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        public abstract void Log(string text);
    }
}
