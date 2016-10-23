using System;
using System.CodeDom;

namespace _02_Mediator_aircraft
{
    public abstract class Aircraft
    {
        private readonly IAirTrafficControl _airTrafficControl;
        private int _currentAltitude;

        public abstract int Celling { get; }
        public string CallSign { get; }

        public int Altitude
        {
            get { return _currentAltitude; }
            set
            {
                _currentAltitude = value;
                _airTrafficControl.ReceiveAircraftLocation(this);
            }
        }
        protected Aircraft(IAirTrafficControl airTrafficControl, string callSign)
        {
            _airTrafficControl = airTrafficControl;
            CallSign = callSign;
            _airTrafficControl.RegisterAircraftUnderGuidance(this);
        }

        public void Climb(int heightToClimb)
        {
            Altitude += heightToClimb;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;
            var incoming = (Aircraft) obj;
            return CallSign.Equals(incoming.CallSign);
        }

        public override int GetHashCode()
        {
            return CallSign.GetHashCode();
        }

        public static bool operator ==(Aircraft a1, Aircraft a2)
        {
            return !ReferenceEquals(a1, null) && a1.Equals(a2);
        }

        public static bool operator !=(Aircraft a1, Aircraft a2)
        {
            return !(a1 == a2);
        }

        public void WarnOfAirspaceIntrusionBy(Aircraft reportingAircraft)
        {
            Console.WriteLine($"{GetType().Name} got warning from {reportingAircraft.GetType().Name}");
        }
    }
}
