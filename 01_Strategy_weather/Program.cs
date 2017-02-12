using System;

namespace _01_Strategy_weather
{
    internal class Program
    {
        private static void Main()
        {
            var me = new MySelf
            {
                Strategy = new RainingWeather()
            };
            me.GoOutside();

            Console.Read();
        }
    }
}
