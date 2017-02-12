using System;

namespace _03_Observer
{
    // Besides this digital clock could be another observers like
    // analog clock and so on
    public class DigitalClock : Observer
    {
        private TimeSpan _currentTime;
        private Subject _subject;
        public DigitalClock(Subject subject)
        {
            _subject = subject;
        }
        public override void Update(Subject subject)
        {
            var clockTimer = subject as ClockTimer;
            if (clockTimer != null)
            {
                _currentTime = clockTimer.GetTime();
            }
            Console.WriteLine($"Time: {_currentTime}");
        }
    }
}