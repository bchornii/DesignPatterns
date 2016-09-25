using System;

namespace _02_Adapter_Duck
{
    public class MallartDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }

        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }
}
