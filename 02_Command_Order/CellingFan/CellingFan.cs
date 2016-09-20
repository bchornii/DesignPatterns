using System;

namespace _02_Command_Order
{
    public class CellingFan
    {
        public Speed FanSpeed { get; private set; }
        private string _location;

        public CellingFan(string location)
        {
            _location = location;
            FanSpeed = Speed.Off;
        }

        public void SetHigh()
        {
            FanSpeed = Speed.High;
            InfoMessage(FanSpeed.ToString());
        }

        public void SetMedium()
        {
            FanSpeed = Speed.Medium;
            InfoMessage(FanSpeed.ToString());
        }

        public void SetLow()
        {
            FanSpeed = Speed.Low;
            InfoMessage(FanSpeed.ToString());
        }

        public void SetOff()
        {
            FanSpeed = Speed.Off;
            InfoMessage(FanSpeed.ToString());
        }

        public void SetCustom(Speed speed)
        {
            FanSpeed = speed;
            InfoMessage(FanSpeed.ToString());
        }

        private static void InfoMessage(string message)
        {
            Console.WriteLine($"Speed was changed to {message}");
        }
    }
}
