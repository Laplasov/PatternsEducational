using Patterns.Structural.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Observer
{
    internal class Observer<T> : IObserver<T>
    {
        private readonly string _name;
        public Observer(string name) => _name = name;

        public void OnNext(T value) => Console.WriteLine($"[OBSERVER - {_name}] Received: {value}");
        public void OnError(Exception error) => Console.WriteLine($"[ERROR] {error.Message}");
        public void OnCompleted() => Console.WriteLine($"[COMPLETED OBSERVER - {_name}]");
    }
}
