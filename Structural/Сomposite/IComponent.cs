using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Сomposite
{
    internal interface IComponent
    {
        public string Name { get; }
        public void Show();

    }
}
