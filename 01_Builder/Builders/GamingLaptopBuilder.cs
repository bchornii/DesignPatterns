namespace _01_Builder
{
    public class GamingLaptopBuilder : LaptopBuilder
    {
        public override void SetBattery()
        {
            Laptop.Battery = "6 lbs";
        }

        public override void SetHDD()
        {
            Laptop.HDD = "500 Gb";
        }

        public override void SetMemory()
        {
            Laptop.Memory = "6144 MB";
        }

        public override void SetMonitorResolution()
        {
            Laptop.MonitorResolution = "1920X1200";
        }

        public override void SetProcessor()
        {
            Laptop.Processor = "Core 2 Quad, 3.7Gz";
        }
    }
}
