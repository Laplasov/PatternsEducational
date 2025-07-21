using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Command
{
    internal class Receiver
    {
        public void Add(string text) => Console.WriteLine(text);
        public void Remove(string text) => Console.WriteLine(text);
    }
}
