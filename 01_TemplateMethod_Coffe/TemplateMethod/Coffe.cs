using System;

namespace _01_TemplateMethod_Coffe
{
    public class Coffe : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Brew coffe");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Add sugar to coffe");
            Console.WriteLine("Add milk");
        }
    }
}