using System;

namespace _03_Observer
{
    // This is concrette subject
    public class ClockTimer : Subject
    {
        private System.Threading.Timer _timer;
        private TimeSpan _currentTime;

        private static void TimeProc(object o)
        {
            (o as ClockTimer)?.Tick();
        }

        public ClockTimer()
        {
            _timer = new System.Threading.Timer(TimeProc, this, 1000, 1000);
        }

        public void Tick()
        {
            _currentTime = DateTime.Now.TimeOfDay;
            Notify();
        }

        public int GetHour()
        {
            return _currentTime.Hours;
        }
        public int GetMinute()
        {
            return _currentTime.Minutes;
        }
        public int GetSecond()
        {
            return _currentTime.Seconds;
        }
        public TimeSpan GetTime()
        {
            return _currentTime;
        }
    }
}