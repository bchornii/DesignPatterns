using System;
using System.Collections.Generic;

namespace _02_CompositeGoF
{
    public class OrderComponent : IComponent
    {
        private int OrderId { get; }
        private readonly List<string> _orders = new List<string>();
        public OrderComponent(int id)
        {
            OrderId = id <= 3 ? id : 3;
            InitDb();
        }
        public string GatherData()
        {
            return $"<Order>{_orders[OrderId]}</Order>";
        }
        private void InitDb()
        {
            _orders.AddRange(new List<string>
            {
                "Bread",
                "Milk",
                "Water",
                "Juice"
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
