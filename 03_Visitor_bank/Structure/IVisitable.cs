namespace _03_Visitor_bank
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}