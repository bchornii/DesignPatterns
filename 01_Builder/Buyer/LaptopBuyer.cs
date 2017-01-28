namespace _01_Builder
{
    public class LaptopBuyer
    {
        private readonly LaptopBuilder _laptopBuilder;

        public LaptopBuyer(LaptopBuilder laptopBuilder)
        {
            _laptopBuilder = laptopBuilder;
        }

        public void ConstructLaptop()
        {
            _laptopBuilder.SetMonitorResolution();
            _laptopBuilder.SetProcessor();
            _laptopBuilder.SetMemory();
            _laptopBuilder.SetHdd();
            _laptopBuilder.SetBattery();            
        }
    }
}
