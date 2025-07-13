using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    internal class ConcretePrototypeA : Prototype
    {
        public ConcretePrototypeA(string name, int value) 
        {
            Name = name;
            Value = value;
        }
        public override PrototypeType Type { get; } = PrototypeType.TypeA;
        private string Name { get; set; }
        private int Value { get; set; }
        public override Prototype Clone() => new ConcretePrototypeA(Name, Value);
        public override string GetString() => $"{Type.ToString()} - Name/Value: {Name}/{Value}.";

    }
}
