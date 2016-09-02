namespace _01_Fasade
{
    public class HotelBookingSystem
    {
        public int BookRoom(int roomQuality)
        {
            switch (roomQuality)
            {
                case 3: return 250;
                case 4: return 300;
                case 5: return 400;
                default: return 0;
            }
        }
    }
}
