namespace _01_Builder
{
    public class TripLaptopBuilder : LaptopBuilder
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
            Laptop.Memory = "2048 MB";
        }

        public override void SetMonitorResolution()
        {
            Laptop.MonitorResolution = "1320X768";
        }

        public override void SetProcessor()
        {
            Laptop.Processor = "Core 2 Core, 1.7Gz";
        }
    }
}
