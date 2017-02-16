using System;
using System.Collections.Generic;

namespace _06_Visitor_Airlines
{
    internal class Program
    {
        private static void Main()
        {
            var products = new List<Product>
            {
                new Book(200),new Book(205),new Book(303),new Wine(706)
            };

            var pricevisitor = new BasicPriceVisitor();
            products.ForEach(x =>
            {
                x.Accept(pricevisitor);
            });
            Console.WriteLine($"Total price {pricevisitor.TotalPrice}, tax {pricevisitor.TaxtToPay}");

            var corporateVisitor = new CorporatePriceVisitor();
            products.ForEach(x =>
            {
                x.Accept(corporateVisitor);
            });
            Console.WriteLine($"Total price {corporateVisitor.TotalPrice}, tax {corporateVisitor.TaxtToPay}");
            
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
