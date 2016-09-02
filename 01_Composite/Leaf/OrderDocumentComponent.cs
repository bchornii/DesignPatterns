namespace _01_Composite
{
    class OrderDocumentComponent : IDocumentComponent
    {
        private int OrderIdGatherData { get; set; }
        public OrderDocumentComponent(int orderIdGatherData)
        {
            OrderIdGatherData = orderIdGatherData;
        }
        public void AddComponent(IDocumentComponent documentComponent)
        {
            
        }

        public string GatherData()
        {
            string gatherData;
            switch (OrderIdGatherData)
            {
                case 0: gatherData = "Kindle1,Kindle2";
                    break;
                case 1: gatherData = "Apple 4";
                    break;
                default: gatherData = "Unknown";
                    break;
            }
            return string.Format(" <Order>{0}</Order>\n", gatherData);
        }
    }
}
