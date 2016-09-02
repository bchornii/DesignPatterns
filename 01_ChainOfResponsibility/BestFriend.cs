using System;
using System.Collections.Generic;

namespace _01_ChainOfResponsibility
{
    public class BestFriend : CafeVisitor
    {
        public List<Food> CoffeContainingFood { get; private set; }
        public BestFriend(CafeVisitor cafeVisitor) : base(cafeVisitor)
        {
            CoffeContainingFood = new List<Food>();
        }
        public override void HandleFood(Food food)
        {
            if (food.Ingridients.Contains("Meat"))
            {
                Console.WriteLine("Best friend : I just ate {0}. It was tasty.", food.Name);
                return;
            }
            if (food.Ingridients.Contains("Coffe") && CoffeContainingFood.Count < 1)
            {
                CoffeContainingFood.Add(food);
                Console.WriteLine("Best friend: I just take something with coffe. {0} looks fine.",food.Name);
                return;
            }
            base.HandleFood(food);
        }
    }
}
