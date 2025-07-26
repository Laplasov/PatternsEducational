using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Strategy
{
    internal interface IStrategy
    {
        public void Execute(string message);
    }
}
