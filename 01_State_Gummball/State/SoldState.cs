using System;

namespace _01_State_Gummball
{
    public class SoldState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuater()
        {
            Console.WriteLine("Please wait, we're already giving you a gumbal");
        }

        public void EjectQuater()
        {
            Console.WriteLine("Sorry you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumbal!!");
        }

        public void Dispense()
        {
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.State = _gumballMachine.NoQuarterState;
            }
            else
            {
                Console.WriteLine("Ooops, out of gumballs");
                _gumballMachine.State = _gumballMachine.SoldOutState;
            }
        }
    }
}