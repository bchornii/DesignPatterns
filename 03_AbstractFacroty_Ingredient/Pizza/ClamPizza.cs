using System;

namespace _03_AbstractFacroty_Ingredient
{
    public class ClamPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _factory;
        public ClamPizza(IPizzaIngredientFactory factory)
        {
            _factory = factory;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing : " + Name);
            Dough = _factory.CreateDough();
            Sauce = _factory.CreateSauce();
            Cheese = _factory.CreateCheese();
        }
    }
}