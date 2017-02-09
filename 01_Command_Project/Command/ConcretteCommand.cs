namespace _01_Command_Project
{
    public class ConcretteCommand : Command
    {
        public ConcretteCommand(Receiver receiver) 
            : base(receiver)
        {
        }

        public override void Execute()
        {
            Receiver.Action();
        }
    }
}