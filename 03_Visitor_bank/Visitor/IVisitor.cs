namespace _03_Visitor_bank
{
    public interface IVisitor
    {
        void VisitPersonAcc(Person person);
        void VisitCompanyAcc(Company company);
    }
}