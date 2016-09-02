namespace _02_Decorator_Coffe
{
    class CoffeDecorator : Coffe
    {
        protected Coffe decorate;
        public CoffeDecorator(Coffe _decorate)
        {
            decorate = _decorate;
        }
        public override void Make()
        {
            decorate.Make();
        }
    }
}
