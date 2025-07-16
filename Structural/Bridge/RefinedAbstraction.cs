using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Bridge
{
    internal class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IImplementor implementor) : base(implementor) { }
        public override void Log(string text) => 
            Console.WriteLine(m_implementor.Refine(text));

    }
}
