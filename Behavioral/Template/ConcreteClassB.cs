using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Template
{
    internal class ConcreteClassB : AbstractClass
    {
        protected override void DoHeader() => Console.WriteLine("Concrete Class B header.");
        protected override void DoBody() => Console.WriteLine("Concrete Class B body.");
        protected override void DoFooter() => Console.WriteLine("Concrete Class B footer.");
        protected override bool Hook() => false;
    }
}
