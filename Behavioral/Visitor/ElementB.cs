using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Visitor
{
    sealed class ElementB : IElement
    {
        public string NameB { get; set; } = "Element B";
        public void Accept(IVisitor visitor) => visitor.VisitB(this);
    }
}
