using System.Collections.Generic;

namespace _03_Observer
{
    public abstract class Subject
    {
        protected List<Observer> Observers = new List<Observer>();

        public virtual void Attach(Observer observer)
        {
            Observers.Add(observer);
            observer.Update(this);
        }

        public virtual void Detach(Observer observer)
        {
            Observers.Remove(observer);
        }

        public virtual void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update(this);
            }
        }
    }
}