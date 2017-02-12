namespace _02_Mediator_aircraft
{
    public interface IAirTrafficControl
    {
        void ReceiveAircraftLocation(Aircraft aircraft);
        void RegisterAircraftUnderGuidance(Aircraft aircraft);
    }
}
