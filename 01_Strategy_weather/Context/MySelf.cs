using System;

namespace _01_Strategy_weather
{
    public class MySelf
    {
        public IWeatherStrategy Strategy { get; set; }

        public MySelf()
        {
            // default strategy
            Strategy = new SunshineWeather();
        }

        public void GoOutside()
        {
            var clothes = Strategy.GetClothes();
            var accessories = Strategy.GetAccessories();
            Console.WriteLine($"Today I wore {clothes} and took {accessories}");
        }

        public string GetAccessories(string weather)
        {
            return Strategy.GetAccessories();
        }

        public string GetClothes(string weather)
        {
            return Strategy.GetClothes();
        }
    }
}
