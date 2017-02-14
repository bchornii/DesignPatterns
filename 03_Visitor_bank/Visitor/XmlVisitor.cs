using System;

namespace _03_Visitor_bank
{
    public class XmlVisitor : IVisitor
    {
        public void VisitPersonAcc(Person acc)
        {
            var result = "<Person><Name>" + acc.Name + "</Name>" +
                         "<Number>" + acc.Number + "</Number><Person>";
            Console.WriteLine(result);
        }

        public void VisitCompanyAcc(Company acc)
        {
            var result = "<Company><Name>" + acc.Name + "</Name>" +
                         "<RegNumber>" + acc.RegNumber + "</RegNumber>" +
                         "<Number>" + acc.Number + "</Number><Company>";
            Console.WriteLine(result);
        }
    }
}