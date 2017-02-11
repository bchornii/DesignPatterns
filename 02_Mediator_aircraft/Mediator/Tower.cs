using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Mediator_aircraft
{
    public class Tower : IAirTrafficControl
    {
        private readonly IList<Aircraft> _aircraftUnderGuidance = new List<Aircraft>();
        public void ReceiveAircraftLocation(Aircraft aircraft)
        {
            foreach (var currentAircraft in _aircraftUnderGuidance.Where(a => a != aircraft))
            {
                if (Math.Abs(currentAircraft.Altitude - aircraft.Altitude) < 1000)
                {
                    aircraft.Climb(1000);
                    // comunicate to the class
                    currentAircraft.WarnOfAirspaceIntrusionBy(aircraft);
                }
            }
        }

        public void RegisterAircraftUnderGuidance(Aircraft aircraft)
        {
            if (!_aircraftUnderGuidance.Contains(aircraft))
            {
                _aircraftUnderGuidance.Add(aircraft);;
            }
        }
    }
}
