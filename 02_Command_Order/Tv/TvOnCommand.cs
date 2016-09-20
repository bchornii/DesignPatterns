namespace _02_Command_Order
{
    public class TvOnCommand : ICommand
    {
        private readonly Tv _tv;

        public TvOnCommand(Tv tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.On();
        }

        public void Undo()
        {
            _tv.Off();
        }
    }

    public class TvOffCommand : ICommand
    {
        private readonly Tv _tv;

        public TvOffCommand(Tv tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.Off();
        }

        public void Undo()
        {
            _tv.On();
        }
    }
}