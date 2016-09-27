namespace _01_Iterator_Dinner
{
    public class MenuItem
    {
        public string Name { get; }
        public string Description { get; }
        public bool Vegeterian { get; }
        public double Price { get; }

        public MenuItem(string name, string description, bool vegeterian, double price)
        {
            Name = name;
            Description = description;
            Vegeterian = vegeterian;
            Price = price;
        }
    }
}
