using System;

namespace _05_Visitor_DoubleDispatch
{
    public interface IBar
    {
        void Accept(IBarVisitor visitor);
    }

    public class Bar : IBar
    {
        public virtual void Accept(IBarVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public sealed class FooBar : Bar
    {
        public override void Accept(IBarVisitor visitor)
        {
            visitor.Visit(this);
        }
    }


    public interface IBarVisitor
    {
        void Visit(IBar item);
        void Visit(FooBar item);
        void Visit(Bar item);
    }

    public class PrintBarVisitor : IBarVisitor
    {
        public void Visit(IBar item)
        {
            ConsolePrinter.Print(item);
        }

        public void Visit(FooBar item)
        {
            ConsolePrinter.Print(item);
        }

        public void Visit(Bar item)
        {
            ConsolePrinter.Print(item);
        }
    }

    // Simple helper for demonstration
    public static class ConsolePrinter
    {
        public static void Print(IBar item)
        {
            Console.WriteLine("IBar");
        }

        public static void Print(Bar item)
        {
            Console.WriteLine("Bar");
        }

        public static void Print(FooBar item)
        {
            Console.WriteLine("FooBar");
        }
    }
    internal class Program
    {
        private static void Main()
        {
            var bar = new Bar();
            var foo = new FooBar();
            IBar ibar = new FooBar();

            IBar[] items = { bar, foo, ibar };


            //// dynamic makes double dispatch possible
            //foreach (dynamic item in items)
            //{
            //    ConsolePrinter.Print(item);
            //}

            var visitor = new PrintBarVisitor();
            
            foreach (var item in items)
            {
                item.Accept(visitor);
            }

            Console.Read();
        }
    }
}
