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
        public static T Instance 
        { 
            get {
                if (m_instance == null)
                {
                    var _newSingleton = new T();
                    SingletonRegistry.Register(_newSingleton);
                    m_instance = _newSingleton;
                }
                return m_instance; 
            }
        }
        static T? m_instance;
        public virtual string GetInfo() => "Base";

    }
}
