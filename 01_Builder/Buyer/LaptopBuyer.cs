namespace _01_Builder
{
    public class LaptopBuyer
    {
        private LaptopBuilder _laptopBuilder;
        public void SetLaptopBuilder(LaptopBuilder builder)
        {
            _laptopBuilder = builder;
        }
        public Laptop ConstructLaptop()
        {
            _laptopBuilder.SetMonitorResolution();
            _laptopBuilder.SetProcessor();
            _laptopBuilder.SetMemory();
            _laptopBuilder.SetHDD();
            _laptopBuilder.SetBattery();
            return _laptopBuilder.GetLaptop();
        }
    }
}
