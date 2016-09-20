namespace _02_Command_Order
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
