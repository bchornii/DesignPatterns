using System;

namespace _01_TemplateMethod_Coffe
{
    internal class Program
    {
        private static void Main()
        {
            var tea = new Tea();
            var coffe = new Coffe();

            tea.Recipe();
            Console.WriteLine(new string('-', 80));
            coffe.Recipe();

            Console.Read();
        }
    }
}
