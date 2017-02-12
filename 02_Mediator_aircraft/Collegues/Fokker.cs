namespace _02_Mediator_aircraft
{
    public class Fokker : Aircraft
    {
        public Fokker(IAirTrafficControl airTrafficControl, string callSign) 
            : base(airTrafficControl, callSign)
        {
        }

        public override int Celling => 40000;
    }
}
