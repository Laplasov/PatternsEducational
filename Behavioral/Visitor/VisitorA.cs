using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Visitor
{
    internal class VisitorA : IVisitor
    {
        public void VisitA(ElementA element) => Console.WriteLine($"Visitor A visit [{element.NameA}].");
        public void VisitB(ElementB element) => Console.WriteLine($"Visitor A visit [{element.NameB}].");

    }
}
