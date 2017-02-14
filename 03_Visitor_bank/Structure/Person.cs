namespace _03_Visitor_bank
{
    public class Person : IVisitable
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitPersonAcc(this);
        }
    }
}