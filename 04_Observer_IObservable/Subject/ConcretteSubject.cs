using System;
using System.Collections.Generic;

namespace _04_Observer_IObservable
{
    public class ConcretteSubject : IObservable<string>, IDisposable
    {
        public string State { get; set; }
        private readonly List<IObserver<string>> _observers = new List<IObserver<string>>();

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                if (State == null)
                {
                    observer.OnError(new NullReferenceException());
                }
                else
                {
                    observer.OnNext(State); // Модель проталкивания.
                }
            }
        }

        // Реализация интерфейса IObservable<T>
        // (UnSubscribe выполняется через IDisposable)
        /// <summary>
        /// Подписать подписчика.
        /// </summary>
        /// <param name="observer">Конкретный подписчик</param>
        /// <returns>Объект отписывающий подписанного подписчика</returns>        
        public IDisposable Subscribe(IObserver<string> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return new Unsubscribe(_observers, observer);
        }

        public void Dispose()
        {
            _observers.Clear();
        }

        // Nested class
        private class Unsubscribe : IDisposable
        {
            private readonly List<IObserver<string>> _observers;
            private readonly IObserver<string> _observer;

            public Unsubscribe(List<IObserver<string>> observers, IObserver<string> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observers.Contains(_observer))
                {
                    _observers.Remove(_observer);
                }
                else
                {
                    _observer.OnError(new Exception("This observer hasn't subscribed."));
                }
            }
        }
    }
}