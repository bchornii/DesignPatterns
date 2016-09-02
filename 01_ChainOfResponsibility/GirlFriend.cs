using System;

namespace _01_ChainOfResponsibility
{
    public class GirlFriend : CafeVisitor
    {
        public GirlFriend(CafeVisitor visitor) : base(visitor)
        {
        }
        public override void HandleFood(Food food)
        {
            if (food.Name == "Capuccino")
            {
                Console.WriteLine("Girl friend : My lovely capuccino!!!");
                return;
            }
            if(food.Name == "Soup")
            {
                Console.WriteLine("Girl friend : I just take some {0}.",food.Name);
            }
            throw new Exception("No one couldn't handle.");
        }
    }
}
