using System;
using System.Collections.Generic;
using System.Threading;

namespace _01_Observer
{
    public class TemperatureMonitor : IObservable<Temperature>
    {
        List<IObserver<Temperature>> _observers;
        public TemperatureMonitor()
        {
            _observers = new List<IObserver<Temperature>>();
        }
        public IDisposable Subscribe(IObserver<Temperature> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return new Unsubscribe(_observers, observer);
        }

        public void GetTemperature()
        {
            decimal? [] temps = {14.6m, 14.65m, 14.7m, 14.9m, 14.9m, 15.2m, 15.25m, 15.2m,
                                15.4m, 15.45m, null };
            decimal? previous = null;
            bool start = true;

            foreach (var temp in temps)
            {
                Thread.Sleep(2500);
                if (temp.HasValue)
                {
                    if(start || Math.Abs(temp.Value - previous.Value) >= 0.1m)
                    {
                        var tempData = new Temperature(temp.Value, DateTime.Now);
                        foreach (var o in _observers)
                        {
                            o.OnNext(tempData);
                        }
                        previous = temp;
                        start = start ? false : start;
                    }
                }
                else
                {
                    foreach (var o in _observers)
                    {
                        o?.OnCompleted();
                    }
                    _observers.Clear();
                    break;
                }
            }
        }

        private class Unsubscribe : IDisposable
        {
            private List<IObserver<Temperature>> _observers;
            private IObserver<Temperature> _observer;
            public Unsubscribe(List<IObserver<Temperature>> observers,
                IObserver<Temperature> observer)
            {
                _observers = observers;
                _observer = observer;
            }
            public void Dispose()
            {
                if(_observers != null)
                {
                    _observers.Remove(_observer);
                }
            }
        }
    }
}
