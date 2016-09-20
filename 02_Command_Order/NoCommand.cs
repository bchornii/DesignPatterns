namespace _02_Command_Order
{
    public class NoCommand : ICommand
    {
        public void Execute() { }

        public void Undo() { }        
    }
}
