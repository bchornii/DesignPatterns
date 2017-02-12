namespace _01_Strategy_weather
{
    public class SunshineWeather : IWeatherStrategy
    {
        public string GetClothes()
        {
            return "T-shirt";
        }

        public string GetAccessories()
        {
            return "sunglasses";
        }
    }
}
