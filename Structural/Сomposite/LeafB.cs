using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Сomposite
{
    internal class LeafB : IComponent
    {
        public string Name { get; } = "LeafB";
        public void Show() => Console.WriteLine($"List of {Name}");
    }
}
