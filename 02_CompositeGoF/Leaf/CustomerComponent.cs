using System.Collections.Generic;

namespace _02_CompositeGoF
{
    class CustomerComponent : ILeafComponent
    {
        private int CustomerId { get; set; }
        private List<string> data = new List<string>();
        public CustomerComponent(int id)
        {
            CustomerId = id <= 3 ? id : 3;
            InitDb();
        }
        public string GatherData()
        {
            return string.Format("<Customer>{0}</Customer>", data[CustomerId]);
        }

        private void InitDb()
        {
            data.AddRange(new List<string>
            {
                "Andriy Buday",
                "Ivan Petrov",
                "Oleg Ivanov",
                "Andtiy Valuev"
            });
        }
    }
}
