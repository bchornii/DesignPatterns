namespace _01_Visitor_office
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
