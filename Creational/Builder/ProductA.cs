using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    internal record ProductA
    {
        public string Product { get; set; } = "Part_A";
        public string Name { get; set; } = "Not specified!";
        public int Id { get; set; } = 0;
    }
}
