namespace _02_Decorator_Coffe
{
    public class CoffeDecorator : Coffe
    {
        protected Coffe CoffeComponent;
        public CoffeDecorator(Coffe coffeComponent)
        {
            CoffeComponent = coffeComponent;
        }
        public override void Make()
        {
            CoffeComponent.Make();
        }
    }
}
