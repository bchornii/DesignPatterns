using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Ми можемо користуватися новою системою без проблем
            var newElectricitySystem = new NewElectricitySystem();
            ElectricityConsumer.ChargeNotebook(newElectricitySystem);

            // 2. Для старої системи ми використовуємо адаптер
            var oldElectricitySystem = new OldElectricitySystem();
            Adapter adapter = new Adapter(oldElectricitySystem);
            ElectricityConsumer.ChargeNotebook(adapter);

            Console.ReadLine();
        }
    }
}
