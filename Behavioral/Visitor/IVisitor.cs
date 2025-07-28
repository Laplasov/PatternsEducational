using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Visitor
{
    internal interface IVisitor
    {
        public void VisitA(ElementA element);
        public void VisitB(ElementB element);
    }
}
