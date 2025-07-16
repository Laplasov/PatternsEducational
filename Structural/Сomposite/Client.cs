using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Сomposite
{
    internal class Client
    {
        public Client() 
        {
            var composite = new Composite("Composite");
            composite.Add(new LeafA());
            composite.Add(new LeafB());
            composite.Add(new LeafC());
            composite.Show();

        }
    }
}
