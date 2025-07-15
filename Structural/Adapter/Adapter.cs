using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Adapter
{
    enum AdapterType { TypeA, TypeB }
    internal class Adapter : AdapteeA, ITarget
    {
        AdapteeB AdapteeB { get; set; }
        public Adapter() 
        {
            AdapteeB = new AdapteeB();
        }
        public string Executor(AdapterType type) 
        {
            return type switch
            {
                AdapterType.TypeA => GetAdapteeA(),
                AdapterType.TypeB => AdapteeB.GetAdapteeB(),
                _ => throw new NotSupportedException()
            };
        }
    }
}
