using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    internal record ProductC
    {
        public string Product { get; set; } = "Part_C";
        public string Name { get; set; } = "Not specified!";
        public string Comment { get; set; } = "Not specified!";
    }
}
