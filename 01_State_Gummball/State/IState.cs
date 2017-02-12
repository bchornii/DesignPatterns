namespace _01_State_Gummball
{
    public interface IState
    {
        void InsertQuater();
        void EjectQuater();
        void TurnCrank();
        void Dispense();
    }
}
