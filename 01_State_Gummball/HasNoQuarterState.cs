namespace _01_State_Gummball
{
    public class HasNoQuarterState : IState
    {
        private GumballMachine _gumballMachine;

        public HasNoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuater()
        {
            throw new System.NotImplementedException();
        }

        public void EjectQuater()
        {
            throw new System.NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new System.NotImplementedException();
        }

        public void Dispense()
        {
            throw new System.NotImplementedException();
        }
    }
}