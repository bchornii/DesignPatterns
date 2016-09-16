using System;
using System.IO;

namespace _06_Decorator_IO
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var lcstream = new LoweCaseInputStream(new FileInfo("hello dear.txt"));
            var ucstream = new UpperCaseInputStream(new FileInfo("hello again.txt"));
            Console.WriteLine(lcstream.FullName);
            Console.WriteLine(ucstream.FullName);

            Console.Read();
        }
    }
}
