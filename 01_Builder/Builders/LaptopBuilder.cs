namespace _01_Builder
{
    public abstract class LaptopBuilder
    {
        protected Laptop Laptop { get; }
        protected LaptopBuilder()
        {
            Laptop = new Laptop();
        }
        public Laptop GetLaptop()
        {
            return Laptop;
        }
        public abstract void SetMonitorResolution();
        public abstract void SetProcessor();
        public abstract void SetMemory();
        public abstract void SetHdd();
        public abstract void SetBattery();
    }
}
