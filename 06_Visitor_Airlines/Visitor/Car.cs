namespace _06_Visitor_Airlines
{
    public class Car : Product
    {
        public Car(int price)
        {
            Price = price;
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}