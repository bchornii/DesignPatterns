using System;

namespace _02_TemplateMethod_MessSearch
{
    public class ImportantMessageSearcher : MessageSearcher
    {
        public ImportantMessageSearcher(DateTime dateSent, string personName, int impLevel) 
            : base(dateSent, personName, impLevel)
        {
        }

        protected override void CreateImportanceLevel()
        {
            Console.WriteLine("Special importance criteria has been formed : SPECIAL");
        }
    }
}