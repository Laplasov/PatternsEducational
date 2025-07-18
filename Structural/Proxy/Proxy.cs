using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Proxy
{
    internal class Proxy : ISubject
    {
        public Proxy(AccessType type, RealSubject subject)
        {
            m_accessType = type;
            m_subject = subject;
        } 

        private readonly ISubject m_subject;
        private readonly AccessType m_accessType;
        public void Show()
        {
            if ((m_accessType == AccessType.Full) || (m_accessType == AccessType.Read))
                m_subject.Show();
            else
                Console.WriteLine("Forbidden to see.");
        }
        public void Edit()
        {
        if ((m_accessType == AccessType.Full) || (m_accessType == AccessType.Write))
                m_subject.Edit();
            else
                Console.WriteLine("Forbidden to edit.");
        }
    }
}
