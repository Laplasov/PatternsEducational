using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    internal abstract class Singleton<T> : ISingleton where T : Singleton<T>, new()
    {
        protected Singleton() { }

        private static readonly Lazy<T> _instance = new(() =>
        {
            var instance = new T();
            SingletonRegistry.Register(instance);
            return instance;
        });

        public static T Instance => _instance.Value;
        public virtual string GetInfo() => "Base";

    }
}
