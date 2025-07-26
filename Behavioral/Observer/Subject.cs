using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Observer
{
    public class Subject<T> : IObservable<T>
    {
        public T? CurrentValue { get; private set; }
        public event Action<T>? ValueChanged;
        public void Update(T newValue)
        {
            CurrentValue = newValue;
            ValueChanged?.Invoke(newValue);
        }
        public IDisposable Subscribe(IObserver<T> observer)
        {
            ValueChanged += observer.OnNext;
            return new Unsubscriber(() => ValueChanged -= observer.OnNext);
        }

        private class Unsubscriber : IDisposable
        {
            private readonly Action _unsubscribe;
            public Unsubscriber(Action unsubscribe) => _unsubscribe = unsubscribe;
            public void Dispose() => _unsubscribe?.Invoke();
        }
    }
}
