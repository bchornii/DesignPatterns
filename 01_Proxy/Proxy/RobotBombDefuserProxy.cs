using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Proxy
{
    public class RobotBombDefuserProxy : RobotBombDefuser
    {
        private RobotBombDefuser _robotDefuser;
        private int _communicationWavelenght;
        private int _connectionAttempts = 3;

        public RobotBombDefuserProxy(int communicationWavelenght)
        {
            _robotDefuser = new RobotBombDefuser();
            _communicationWavelenght = communicationWavelenght;
        }

        public override void WalkStraightForward(int steps)
        {
            EnsureConnectWithRobot();
            _robotDefuser.WalkStraightForward(steps);
        }

        public override void TurnLeft()
        {
            EnsureConnectWithRobot();
            _robotDefuser.TurnLeft();
        }

        public override void TurnRight()
        {
            EnsureConnectWithRobot();
            _robotDefuser.TurnRight();
        }

        public override void DefuseBomb()
        {
            EnsureConnectWithRobot();
            _robotDefuser.DefuseBomb();
        }

        private void EnsureConnectWithRobot()
        {
            if(_robotDefuser == null)
            {
                _robotDefuser = new RobotBombDefuser();
                _robotDefuser.ConnectWireless(_communicationWavelenght);
            }
            for (int i = 0; i < _connectionAttempts; i++)
            {
                if(_robotDefuser.IsConnected() != true)
                {
                    _robotDefuser.ConnectWireless(_communicationWavelenght);
                }
                else
                {
                    break;
                }
                if(_robotDefuser.IsConnected() != true)
                {
                    throw new Exception("No connection with robot...");
                }
            }
        }
    }
}
