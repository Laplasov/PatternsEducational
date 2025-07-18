using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Facade
{
    internal class MemberA : IMember
    {
        public string Execute(string text)
        {
            return "MemberA - " + text ;
        }
    }
}
