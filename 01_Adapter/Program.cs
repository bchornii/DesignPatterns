using System;

namespace _01_Adapter
{
    internal class Program
    {
        private static void Main()
        {
            // 1. Ми можемо користуватися новою системою без проблем
            var newElectricitySystem = new NewElectricitySystem();
            ElectricityConsumer.ChargeNotebook(newElectricitySystem);

            // 2. Для старої системи ми використовуємо адаптер
            var oldElectricitySystem = new OldElectricitySystem();
            var adapter = new Adapter(oldElectricitySystem);
            ElectricityConsumer.ChargeNotebook(adapter);

            Console.ReadLine();
        }
    }
}
