using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    internal record ProductB
    {
        public string Product { get; set; } = "Part_B";
        public string Name { get; set; } = "Not specified!";
        public string Location { get; set; } = "Not specified!";
    }
}
