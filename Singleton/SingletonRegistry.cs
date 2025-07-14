using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    internal class SingletonRegistry
    {
        private static readonly ConcurrentBag<ISingleton> _instances = new();

        public static void Register(ISingleton instance)
        {
            if (!_instances.Contains(instance))
                _instances.Add(instance);
        }

        public static IReadOnlyList<ISingleton> GetAllInstances() => 
            new List<ISingleton>(_instances).AsReadOnly();
    }
}
