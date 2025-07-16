using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Bridge
{
    internal class ConcreteImplementorA : IImplementor
    {
        public string Refine(string text) => $"Implemented by A: {text}";
    }
}
