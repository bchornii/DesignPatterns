namespace _03_Visitor_bank
{
    public class Company : IVisitable
    {
        public string RegNumber { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitCompanyAcc(this);
        }
    }
}