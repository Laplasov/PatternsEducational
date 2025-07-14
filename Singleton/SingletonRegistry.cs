using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    internal class SingletonRegistry
    {
        private static readonly List<ISingleton> _instances = new();

        public static void Register(ISingleton instance)
        {
            if (!_instances.Contains(instance))
                _instances.Add(instance);
        }

        public static List<ISingleton> GetAllInstances() => _instances;
    }
}
