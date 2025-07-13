using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    internal abstract class Prototype
    {
        public abstract PrototypeType Type { get; }
        public abstract Prototype Clone();
        public abstract string GetString();

    }
}
