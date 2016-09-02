using System;
using System.Collections.Generic;

namespace _02_ChainOfResponsibility_Document
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Document> documents = new List<Document>
            {
                new Document { Id = 1, Content = new string('-',50)},
                new Document { Id = 2, Content = new string('-',860) },
                new Document { Id = 3, Content = new string ('-',2500) }
            };

            IEditor editor = new SimpleEditor(new ExtensiveEditor());
            documents.ForEach(x =>
            {
                var result = editor.ReviewDocument(x);
                Console.WriteLine(result.Approved ? "Document {0} approved by {1}" : "Document {0} rejected {1}", x.Id, result.Reviewer);
            });

            Console.ReadLine();

        }
    }
}
