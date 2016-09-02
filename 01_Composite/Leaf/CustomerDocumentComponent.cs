using System;

namespace _01_Composite
{
    class CustomerDocumentComponent : IDocumentComponent
    {
        private int CustomerIdGatherData { get; set; }
        public CustomerDocumentComponent(int customerIdGatherData)
        {
            CustomerIdGatherData = customerIdGatherData;
        }

        public string GatherData()
        {
            string customerData;
            switch(CustomerIdGatherData)
            {
                case 41: customerData = "Andriy Buday";
                    break;
                default: customerData = "Someone else";
                    break;
            }

            return string.Format(" <Customer>{0}</Customer>\n", customerData);
        }

        public void AddComponent(IDocumentComponent documentComponent)
        {
            Console.Write("Cannot add element to leaf...");
        }
    }
}
