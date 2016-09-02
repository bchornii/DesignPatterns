using System;

namespace _01_Proxy
{
    public class RobotBombDefuser
    {
        private Random _random = new Random();
        private int _robotWavelength = 41;
        private bool _isConnected = false;

        public void ConnectWireless(int communicationWavelenght)
        {
            if (_robotWavelength == communicationWavelenght)
            {
                _isConnected = ImitatingConnectionIssues();
            }
        }

        public bool IsConnected()
        {
            _isConnected = ImitatingConnectionIssues();
            return _isConnected;
        }

        private bool ImitatingConnectionIssues()
        {
            return _random.Next(0, 10) < 4;
        }

        public virtual void WalkStraightForward(int steps)
        {
            Console.WriteLine("Did {0} steps forward...", steps);
        }

        public virtual void TurnRight()
        {
            Console.WriteLine("Turned right...");
        }

        public virtual void TurnLeft()
        {
            Console.WriteLine("Turned left...");
        }

        public virtual void DefuseBomb()
        {
            Console.WriteLine("Cut red or green or blue...))))");
        }
    }
}
