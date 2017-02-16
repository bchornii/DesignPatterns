namespace _06_Visitor_Airlines
{
    public abstract class Product : IVisitable
    {
        public int Price { get; set; }
        public abstract void Accept(IVisitor visitor);
    }
}