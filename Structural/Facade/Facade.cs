using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Facade
{
    internal class Facade : IMember
    {
        private readonly IMember m_A = new MemberA();
        private readonly IMember m_B = new MemberB();
        private readonly IMember m_C = new MemberC();

        public string Execute(string text)
        {
            return m_C.Execute(m_B.Execute(m_A.Execute("Facade - " + text)));
        }
    }
}
