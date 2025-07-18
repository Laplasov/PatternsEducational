using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Flyweight
{
    internal class ConcreteFlyweight : IFlyweight
    {
        private readonly FlyweightType m_type;
        private readonly string m_name;
        private readonly string m_beginning = "Sentence";
        public ConcreteFlyweight(FlyweightType type) { 
            m_type = type;
            m_name = type.ToString();
        }
        public void Say(string massage)
        {
            var timestamp = DateTime.Now.ToString();
            Console.WriteLine($"[{timestamp}]\n{m_beginning}: {m_name} say - {massage}.");
        }

    }
}
