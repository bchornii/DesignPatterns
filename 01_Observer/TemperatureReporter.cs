using System;

namespace _01_Observer
{
    public class TemperatureReporter : IObserver<Temperature>
    {
        private IDisposable _unsubscribe;
        private bool first = true;
        private Temperature last;

        public virtual void Subscribe(IObservable<Temperature> provider)
        {
            _unsubscribe = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            _unsubscribe.Dispose();
        }

        public void OnCompleted()
        {
            Console.WriteLine("Additional temperatures will not be transmitted");
        }

        public void OnError(Exception error)
        {
            // Do nothing
        }

        public void OnNext(Temperature value)
        {
            Console.WriteLine($"The temperature is {value.Degrees}°C at {value.Date}");
            if (first)
            {
                last = value;
                first = false;
            }
            else
            {
                Console.WriteLine($"    Change : {value.Degrees - last.Degrees}°C" + 
                    $" in {value.Date.ToUniversalTime() - last.Date.ToUniversalTime()}");
            }
        }
    }
}
