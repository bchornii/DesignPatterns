using System;

namespace _01_TemplateMethod_Coffe
{
    public abstract class CaffeineBeverage
    {
        public void Recipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public virtual void BoilWater()
        {
            Console.WriteLine("Boil water");
        }

        public virtual void PourInCup()
        {
            Console.WriteLine("Pour in cup");
        }

        public abstract void Brew();
        public abstract void AddCondiments();
    }
}