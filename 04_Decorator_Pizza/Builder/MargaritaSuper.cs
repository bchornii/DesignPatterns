namespace _04_Decorator_Pizza
{
    class MargaritaSuper : PizzaBuilder
    {
        public MargaritaSuper() 
            : base(new Margherita())
        {
        }

        public override void AddExtraCheese()
        {
            Pizza = new ExtraCheesTopping(Pizza);
        }

        public override void AddExtraKetchup()
        {
            Pizza = new KetchupTopping(Pizza);
        }

        public override void AddMushrooms()
        {
            Pizza = new MushroomTopping(Pizza);
        }
    }
}
