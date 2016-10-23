namespace _02_Mediator_aircraft
{
    public class Airbus : Aircraft
    {
        public Airbus(IAirTrafficControl airTrafficControl, string callSign) 
            : base(airTrafficControl, callSign)
        {
        }

        public override int Celling => 40000;
    }
}
