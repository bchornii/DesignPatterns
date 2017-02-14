using System;

namespace _03_Visitor_bank
{
    internal class Program
    {
        private static void Main()
        {
            var structure = new Bank();
            structure.Add(new Person { Name = "Ivan", Number = "93849384"});
            structure.Add(new Company {Name = "Google", Number = "943957345", RegNumber = "394759375"});
            structure.Accept(new HtmlVisitor());
            structure.Accept(new XmlVisitor());

            Console.Read();
        }
    }
}
