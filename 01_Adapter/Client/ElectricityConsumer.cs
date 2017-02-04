using System;

namespace _01_Adapter
{
    public class ElectricityConsumer
    {
        public static void ChargeNotebook(INewElectricitySystem electricitySystem)
        {
            Console.WriteLine(electricitySystem.MathWideSocket());
        }
    }
}
