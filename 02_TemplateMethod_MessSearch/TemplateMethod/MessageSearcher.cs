using System;

namespace _02_TemplateMethod_MessSearch
{
    public abstract class MessageSearcher
    {
        protected DateTime DateSent;
        protected string PersonName;
        protected int ImportanceLevel;

        protected MessageSearcher(DateTime dateSent, string personName, int impLevel)
        {
            DateSent = dateSent;
            PersonName = personName;
            ImportanceLevel = impLevel;
        }

        // Basic operations
        protected virtual void CreateDateCriteria()
        {
            Console.WriteLine("Standart date criteria has been applied");
        }

        protected virtual void CreateSendPersonCriteria()
        {
            Console.WriteLine("Standart send person criteria has been applied");
        }

        protected virtual void CreateImportanceLevel()
        {
            Console.WriteLine("Standart importance level has been applied");
        }

        // Template method
        public string Search()
        {
            CreateDateCriteria();
            CreateSendPersonCriteria();
            Console.WriteLine("Template method does some verification accordingly to search");
            CreateImportanceLevel();
            Console.WriteLine();
            return "Some list of messages...";
        }
    }
}
