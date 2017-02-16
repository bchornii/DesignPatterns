namespace _06_Visitor_Airlines
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}