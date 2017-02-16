namespace _06_Visitor_Airlines
{
    public interface IVisitor
    {
        void Visit(Book book);
        void Visit(Car car);
        void Visit(Wine wine);
    }
}