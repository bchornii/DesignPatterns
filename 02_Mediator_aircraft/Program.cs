using System;

namespace _02_Mediator_aircraft
{
    internal class Program
    {
        private static void Main()
        {
            IAirTrafficControl tower = new Tower();

            Aircraft flight1 = new Airbus(tower, "AC159");
            Aircraft flight2 = new Boeing(tower, "WS203");
            Aircraft flight3 = new Fokker(tower, "AC602");

            flight1.Altitude += 900;
            Console.Read();
        }
    }
}
