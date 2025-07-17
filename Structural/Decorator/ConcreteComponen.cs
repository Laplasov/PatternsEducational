using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Decorator
{
    internal class ConcreteComponen : IComponent
    {
        private readonly string m_text;
        public ConcreteComponen(string text) => m_text = text;
        public string GetText() => m_text; 
    }
}
