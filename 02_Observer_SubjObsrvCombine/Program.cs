using System;

namespace _02_Observer_SubjObsrvCombine
{
    // Observer
    public delegate void Observer(string state);

    // Subject
    public abstract class Subject
    {
        protected Observer Observers = null;

        public event Observer Event
        {
            add { Observers += value; }
            remove { Observers -= value; }
        }
        public abstract string State { get; set; }
        public abstract void Notify();
    }

    public class ConcretteSubject : Subject
    {
        public override string State { get; set; }
        public override void Notify()
        {
            Observers.Invoke(State);
        }
    }

    internal class Program
    {
        private static void Main()
        {
            // Издатель
            var subject = new ConcretteSubject();

            // Підписник з лямбда виразом
            var observer = new Observer(state => Console.WriteLine(state + " 1"));

            // підписка на сповіщення про подію
            subject.Event += observer;
            subject.Event += state => Console.WriteLine(state + " 2");

            subject.State = "State...";
            subject.Notify();

            Console.WriteLine(new string('-', 80));

            // Отписка от уведомлений
            subject.Event -= observer;
            subject.Notify();

            Console.Read();
        }
    }
}
