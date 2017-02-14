using System.Collections.Generic;

namespace _03_Visitor_bank
{
    public class Bank
    {
        private readonly List<IVisitable> _accounts = new List<IVisitable>();

        public void Add(IVisitable acc)
        {
            _accounts.Add(acc);
        }

        public void Remove(IVisitable acc)
        {
            _accounts.Remove(acc);
        }

        public void Accept(IVisitor visitor)
        {
            _accounts.ForEach(a => a.Accept(visitor));
        }
    }
}