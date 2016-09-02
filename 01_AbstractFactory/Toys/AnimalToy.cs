namespace _01_AbstractFactory
{
    public abstract class AnimalToy
    {
        public string Name { get; set; }
        public AnimalToy(string name)
        {
            Name = name;
        }
    }
}
