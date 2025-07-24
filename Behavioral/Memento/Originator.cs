using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patterns.Behavioral.Memento
{
    internal class Originator
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Id { get; set; }

        public Memento Save() => new Memento(Name, Description, Id);

        public void Load(Memento memento)
        {
            Name = memento.Name;
            Description = memento.Description;
            Id = memento.Id;
        }

    }
}
