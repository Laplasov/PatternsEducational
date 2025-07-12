using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    internal record TopObject
    {
        public string Name { get; set; } = "Not specified!";
        public int Id { get; set; } = 0;
        public string Location { get; set; } = "Not specified!";
        public string Comment { get; set; } = "Not specified!";
    }
}
