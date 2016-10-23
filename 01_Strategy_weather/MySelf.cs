using System;

namespace _01_Strategy_weather
{
    public class MySelf
    {
        private IWeatherStrategy _strategy;

        public MySelf()
        {
            _strategy = new SunshineWeather();
        }

        public void GoOutside()
        {
            var clothes = _strategy.GetClothes();
            var accessories = _strategy.GetAccessories();
            Console.WriteLine($"Today I wore {clothes} and took {accessories}");
        }

        public void ChangeStrategy(IWeatherStrategy strategy)
        {
            _strategy = strategy;
        }

        public string GetAccessories(string weather)
        {
            return _strategy.GetAccessories();
        }

        public string GetClothes(string weather)
        {
            return _strategy.GetClothes();
        }
    }
}
