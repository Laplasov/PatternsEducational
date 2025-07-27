using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Template
{
    internal class ConcreteClassA : AbstractClass
    {
        protected override void DoBody() => Console.WriteLine("Concrete Class A body.");
        protected override bool Hook() => true;
    }
}
