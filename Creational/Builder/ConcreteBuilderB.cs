using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patterns.Builder
{
    internal class ConcreteBuilderB : IBuilder
    {
        ProductB productB = new ProductB();
        public void BuildPartA(string name) => productB.Name = name;
        
        public void BuildPartB(int id) { }
        public void BuildPartC(string location) => productB.Location = location;
        public void BuildPartD(string comment) { }
        public string GetResult()
        {
            return $"Product: {productB.Product}\n" +
                $"Name: {productB.Name}\n" +
                $"Location: {productB.Location}\n";
        }
        public void Reset() => productB = new ProductB();
    }
}
