using System.Collections.Generic;

namespace _02_CompositeGoF
{
    class OrderComponent : ILeafComponent
    {
        private int OrderId { get; set; }
        List<string> orders = new List<string>();
        public OrderComponent(int id)
        {
            OrderId = id <= 3 ? id : 3;
            InitDb();
        }
        public string GatherData()
        {
            return string.Format("<Order>{0}</Order>", orders[OrderId]);
        }
        private void InitDb()
        {
            orders.AddRange(new List<string>
            {
                "Bread",
                "Milk",
                "Water",
                "Juice"
            });
        }
    }
}
