using System;

namespace _03_FactoryMethod_Abstract
{
    public class NyStyleCheesPizza : Pizza
    {
        public NyStyleCheesPizza()
        {
            Name = "NY style sauce and cheese pizza";
            Dough = "Thin crust dough";
            Sauce = "Marinara sauce";
        }
    }

    public class ChicagoStyleCheesPizza : Pizza
    {
        public ChicagoStyleCheesPizza()
        {
            Name = "Chicago style sauce and cheese pizza";
            Dough = "Thin crust dough";
            Sauce = "Marinara sauce";
        }

        public override void Cut()
        {
            Console.WriteLine("Cut like in Chicago");
        }
    }
}
