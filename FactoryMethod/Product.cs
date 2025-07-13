using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    internal abstract class Product
    {
        protected Product(string name) => Name = name;
        public string Name { get; } 
        protected string GetName(string name) => Name;
        public abstract string Render();
    }
}
