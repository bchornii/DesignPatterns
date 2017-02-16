namespace _06_Visitor_Airlines
{
    public class Book : Product
    {
        public Book(int price)
        {
            Price = price;
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}