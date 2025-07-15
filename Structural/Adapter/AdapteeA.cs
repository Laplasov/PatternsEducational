using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Adapter
{
    internal class AdapteeA
    {
        public string GetAdapteeA()
        {
            return "Inherited Adaptee.";
        }
    }
}
