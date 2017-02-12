using System;

namespace _04_Observer_IObservable
{
    internal class Program
    {
        private static void Main()
        {
            // subject
            var subject = new ConcretteSubject();

            // observers
            var o1 = new ConcretteObserver("1", subject);
            var o2 = new ConcretteObserver("2", subject);
            var o3 = new ConcretteObserver("3", subject);
            var o4 = new ConcretteObserver("4", subject);

            // Подписание подписчиков на издателя с получением объекта для отписки.
            IDisposable unsubscriber1 = subject.Subscribe(o1);
            IDisposable unsubscriber2 = subject.Subscribe(o2);
            IDisposable unsubscriber3 = subject.Subscribe(o3);
            IDisposable unsubscriber4 = subject.Subscribe(o4);

            using (subject)
            {
                // try to push to observers inconsistent state
                subject.State = null;
                subject.Notify();
                Console.WriteLine(new string('-', 70) + "1");

                using (unsubscriber1)
                {
                    // try to push correct state
                    subject.State = "State 1 ...";
                    subject.Notify();
                }

                Console.WriteLine(new string('-', 70) + "2");
                
                // state 2 receives observers who left subscribed
                subject.State = "State 2 ...";
                subject.Notify();

                Console.WriteLine(new string('-', 70) + "3");

                // unsubscribe observer2 via ConcretteObserver.OnCompleted()
                o2.OnCompleted();

                // state 3 reveives just 2 observers which left subscribed
                subject.State = "State 3 ...";
                subject.Notify();                
            }

            Console.WriteLine(new string('-', 70) + "4");

            // Попытка отписать уже отписанного подписчика, обрабатывается в
            // ConcreteSubject.Unsubscriber.Dispose()
            o4.OnCompleted();

            Console.Read();
        }
    }
}
