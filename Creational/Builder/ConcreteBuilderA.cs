using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    internal class ConcreteBuilderA : IBuilder
    {
        ProductA productA = new ProductA();
        public void BuildPartA(string name) => productA.Name = name;
        public void BuildPartB(int id) => productA.Id = id;
        public void BuildPartC(string location) { }
        public void BuildPartD(string comment) { }
        public string GetResult() 
        {
            return $"Product: {productA.Product}\n" +
                $"Name: {productA.Name}\n" +
                $"Id: {productA.Id}\n";
        }
        public void Reset() => productA = new ProductA();
    }
}
