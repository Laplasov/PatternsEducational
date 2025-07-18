using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Proxy
{
    internal class RealSubject : ISubject
    {
        public void Show() => Console.WriteLine("Private info.");
        public void Edit() => Console.WriteLine("Changing info.");
    }
}
