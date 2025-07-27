using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Template
{
    internal abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            DoHeader();
            DoBody();
            if (Hook())
                DoOptionA();
            else 
                DoOptionB();
            DoFooter();
        }

        protected virtual void DoHeader() => Console.WriteLine("Default header.");
        protected abstract void DoBody();
        protected virtual void DoOptionA() => Console.WriteLine("Option A.");
        protected virtual void DoOptionB() => Console.WriteLine("Option B.");
        protected virtual void DoFooter() => Console.WriteLine("Default footer.");
        protected abstract bool Hook();
    }
}
