using System;

namespace _01_Observer
{
    public class Temperature
    {
        private decimal temp;
        private DateTime tempDate;

        public decimal Degrees => temp;
        public DateTime Date => tempDate;

        public Temperature(decimal temperature, DateTime dateAndTime)
        {
            temp = temperature;
            tempDate = dateAndTime;
        }        
    }
}
