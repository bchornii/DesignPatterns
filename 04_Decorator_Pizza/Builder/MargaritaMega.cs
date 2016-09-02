namespace _04_Decorator_Pizza
{
    class MargaritaMega : PizzaBuilder
    {
        public MargaritaMega() 
            : base(new Margherita())
        {
        }

        public override void AddExtraCheese()
        {
            Pizza = new ExtraCheesTopping(new ExtraCheesTopping(Pizza));
        }

        public override void AddExtraKetchup()
        {
            Pizza = new KetchupTopping(new KetchupTopping(Pizza));
        }

        public override void AddMushrooms()
        {
            Pizza = new MushroomTopping(new MushroomTopping(Pizza));
        }
    }
}
