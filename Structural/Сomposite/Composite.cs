using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Сomposite
{
    internal class Composite : IComponent
    {
        public Composite(string name) => Name = name;
        public string Name { get; }

        readonly List<IComponent> m_children = new();
        public void Add(IComponent component) => m_children.Add(component);
        public void Show() 
        {
            Console.WriteLine($"Composite '{Name}' contains:");
            foreach (var child in m_children)
                child.Show();
        }
    }
}
