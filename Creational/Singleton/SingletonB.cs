using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    internal class SingletonB : Singleton<SingletonB>
    {
        public override string GetInfo() => "SingletonB";
    }
}
