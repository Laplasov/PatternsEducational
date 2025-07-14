using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patterns.Builder
{
    internal class ConcreteBuilderC : IBuilder
    {
        ProductC productC = new ProductC();
        public void BuildPartA(string name) => productC.Name = name;
        public void BuildPartB(int id) { }
        public void BuildPartC(string location) { }
        public void BuildPartD(string comment) => productC.Comment = comment;
        public string GetResult()
        {
            return $"Product: {productC.Product}\n" +
                $"Name: {productC.Name}\n" +
                $"Comment: {productC.Comment}\n";
        }
        public void Reset() => productC = new ProductC();
    }
}
