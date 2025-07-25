using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Observer
{
    internal class Controller<T>
    {
        private Subject<T> _subject = new();
        private readonly List<IObserver<T>> _observers = new();
        public IObservable<T> Observable => _subject;
        public void Publish(T value) => _subject.Update(value);

        public IDisposable Subscribe(IObserver<T> observer)
        {
            var subscription = _subject.Subscribe(observer);
            _observers.Add(observer);
            return subscription;
        }

    }
}
