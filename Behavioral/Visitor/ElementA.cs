using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Visitor
{
    sealed class ElementA : IElement
    {
        public string NameA { get; set; } = "Element A";
        public void Accept(IVisitor visitor) => visitor.VisitA(this);
    }
}
