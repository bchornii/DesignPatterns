namespace _01_Strategy_weather
{
    public class RainingWeather : IWeatherStrategy
    {
        public string GetClothes()
        {
            return "Coat";
        }

        public string GetAccessories()
        {
            return "umbrella";
        }
    }
}
