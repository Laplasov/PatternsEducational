using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Memento
{
    internal sealed record Memento(string Name, string Description, int Id);
}
