using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    internal class SingletonA: Singleton<SingletonA>
    {
        public override string GetInfo() => "SingletonA";
    }
}
