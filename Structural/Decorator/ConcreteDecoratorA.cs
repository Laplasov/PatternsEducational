using Patterns.Structural.Сomposite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Decorator
{
    internal class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent component) : base(component) {}

        public override string GetText() => $"ConcreteDecoratorA - {p_component.GetText()}"; 
    }
}
