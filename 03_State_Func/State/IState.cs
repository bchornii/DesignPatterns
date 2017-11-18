namespace _03_State_Func.State
{
    public interface IState
    {
        string Name { get; set; }
        void Operation1();
        void Operation2();
    }
}