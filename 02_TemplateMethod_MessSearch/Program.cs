using System;

namespace _02_TemplateMethod_MessSearch
{
    internal class Program
    {
        private static void Main()
        {
            MessageSearcher searcher = new ImportantMessageSearcher(DateTime.Today, "Sally", 3);
            searcher.Search();

            searcher = new UselessMessageSearcher(DateTime.Today, "Killer", 0);
            searcher.Search();

            Console.Read();
        }
    }
}
