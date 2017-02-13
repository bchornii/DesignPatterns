using System;

namespace _01_TemplateMethod_Coffe
{
    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Brew tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Add sugar to tea");
        }
    }
}