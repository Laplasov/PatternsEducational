using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Flyweight
{
    internal class FlyweightFactory
    {
        private readonly Dictionary<FlyweightType, IFlyweight> m_flyweightDictionary = new();

        public IFlyweight GetData(FlyweightType type)
        {
            if(!m_flyweightDictionary.TryGetValue(type, out var data))
            {
                data = new ConcreteFlyweight(type);
                m_flyweightDictionary.Add(type, data);
            }
            return data;
        }
    }
}
