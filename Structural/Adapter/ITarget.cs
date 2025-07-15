using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Adapter
{
    internal interface ITarget
    {
        public string Executor(AdapterType type);
    }
}
