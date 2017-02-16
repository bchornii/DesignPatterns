namespace _06_Visitor_Airlines
{
    public class Wine : Product
    {
        public Wine(int price)
        {
            Price = price;
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}