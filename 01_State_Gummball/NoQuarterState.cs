using System;

namespace _01_State_Gummball
{
    public class NoQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuater()
        {
            Console.WriteLine("You inserted quarter");
            _gumballMachine.State = _gumballMachine.HasQuarterState;
        }

        public void EjectQuater()
        {
            Console.WriteLine("You haven't inserted quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there no quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }
    }
}
