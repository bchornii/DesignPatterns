using System;

namespace _01_State_Gummball
{
    public class GumballMachine
    {
        public IState SoldOutState { get; }
        public IState NoQuarterState { get; }
        public IState HasQuarterState { get; }
        public IState SoldState { get; }
        public IState State { get; set; }
        public int Count { get; private set; }

        public GumballMachine(int numberGumballs)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasNoQuarterState(this);
            SoldState = new SoldState(this);
            if (numberGumballs > 0)
            {
                State = NoQuarterState;
            }
        }        

        public void InsertQuarter()
        {
            State.InsertQuater();
        }

        public void EjectQuarter()
        {
            State.EjectQuater();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count != 0)
            {
                Count--;
            }
        }
    }
}
