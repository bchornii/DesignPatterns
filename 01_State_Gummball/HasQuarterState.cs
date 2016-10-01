using System;

namespace _01_State_Gummball
{
    public class HasQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuater()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuater()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.State = _gumballMachine.NoQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            _gumballMachine.State = _gumballMachine.SoldState;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
