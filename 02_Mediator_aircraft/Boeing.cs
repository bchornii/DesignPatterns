namespace _02_Mediator_aircraft
{
    public class Boeing : Aircraft
    {
        public Boeing(IAirTrafficControl airTrafficControl, string callSign) 
            : base(airTrafficControl, callSign)
        {
        }

        public override int Celling => 33000;
    }
}
