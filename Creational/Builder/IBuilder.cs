using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    internal interface IBuilder
    {
        public void BuildPartA(string name);
        public void BuildPartB(int id);
        public void BuildPartC(string location);
        public void BuildPartD(string comment);
        public string GetResult();
        public void Reset();
    }
}
