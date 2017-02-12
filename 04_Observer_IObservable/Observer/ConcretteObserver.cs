using System;

namespace _04_Observer_IObservable
{
    public class ConcretteObserver : IObserver<string>
    {
        private readonly string _name;
        private string _observerState;
        private readonly IDisposable _unsubscriber;

        public ConcretteObserver(string name, IObservable<string> subject)
        {
            _name = name;
            _unsubscriber = subject.Subscribe(this);
        }

        // Аналог Update(argument) - модель проталкивания.
        public void OnNext(string value)
        {
            _observerState = value;
            Console.WriteLine("Observer {0}, State = {1}", _name, _observerState);
        }

        public void OnError(Exception error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Observer {0}, Error: {1}", _name, error.Message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void OnCompleted()
        {
            _unsubscriber.Dispose();
        }
    }
}