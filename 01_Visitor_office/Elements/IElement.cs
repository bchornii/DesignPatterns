using _01_Visitor_office.Visitor;

namespace _01_Visitor_office.Elements
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
