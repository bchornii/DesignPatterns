namespace _01_Adapter
{
    // Розетка нової системи
    class NewElectricitySystem : INewElectricitySystem
    {
        public string MathWideSocket()
        {
            return "New system : 220V AC";
        }
    }
}
