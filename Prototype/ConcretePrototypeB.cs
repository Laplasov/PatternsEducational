using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    internal class ConcretePrototypeB : Prototype
    {
        public ConcretePrototypeB(string title, bool flag)
        {
            Title = title;
            Flag = flag;
        }
        public override PrototypeType Type { get; } = PrototypeType.TypeB;
        private string Title { get; set; }
        private bool Flag { get; set; }
        public override Prototype Clone() => new ConcretePrototypeB(Title, Flag);
        public override string GetString() => $"{Type.ToString()} - Title/Flag: {Title}/{Flag}.";
    }
}
