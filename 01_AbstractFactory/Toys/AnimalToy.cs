namespace _01_AbstractFactory
{
    public abstract class AnimalToy
    {
        public string Name { get; set; }

        protected AnimalToy(string name)
        {
            Name = name;
        }
    }
}
