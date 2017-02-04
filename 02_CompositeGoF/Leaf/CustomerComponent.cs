using System;
using System.Collections.Generic;

namespace _02_CompositeGoF
{
    public class CustomerComponent : IComponent
    {
        private int CustomerId { get; }
        private readonly List<string> _data = new List<string>();
        public CustomerComponent(int id)
        {
            CustomerId = id <= 3 ? id : 3;
            InitDb();
        }
        public string GatherData()
        {
            return $"<Customer>{_data[CustomerId]}</Customer>";
        }

        private void InitDb()
        {
            _data.AddRange(new List<string>
            {
                "Andriy Buday",
                "Ivan Petrov",
                "Oleg Ivanov",
                "Andtiy Valuev"
            });
        }

        public void Add(IComponent component)
        {
            throw new InvalidOperationException();
        }

        public void Remove(IComponent component)
        {
            throw new InvalidOperationException();
        }

        public IComponent GetChild(int index)
        {
            throw new InvalidOperationException();
        }
    }
}
