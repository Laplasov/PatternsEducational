using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Decorator
{
    internal abstract class Decorator : IComponent
    {
        protected readonly IComponent p_component;
        protected Decorator(IComponent component) => p_component = component;
        public abstract string GetText();
    }
}
