using System;

namespace _03_State_Func
{
    internal class Program
    {
        private static void Main()
        {
            var context = new Context.Context();
            context.BussinessLogic();
            context.BussinessLogic();
            context.BussinessLogic();
            context.BussinessLogic();
            Console.Read();
        }
    }
}
