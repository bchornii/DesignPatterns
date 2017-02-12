namespace _01_Strategy_weather
{
    // For this strategy we do not pass any parameters
    // But there are two ways to get data for specific strategy
    // 1. Put data into strategy operation, but in this case we can put
    // data that is not required no some concrette strategy
    // 2. Put context itself to strategy but in this case strategy and context
    // are more coupled to each other and context need to have appropriate interface
    // for data access 
    public interface IWeatherStrategy
    {
        string GetClothes();
        string GetAccessories();
    }
}
