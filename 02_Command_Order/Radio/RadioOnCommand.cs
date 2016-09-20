namespace _02_Command_Order
{
    public class RadioOnCommand : ICommand
    {
        private readonly Radio _radio;

        public RadioOnCommand(Radio radio)
        {
            _radio = radio;
        }

        public void Execute()
        {
            _radio.On();
        }

        public void Undo()
        {
            _radio.Off();
        }
    }

    public class RadioOffCommand : ICommand
    {
        private readonly Radio _radio;

        public RadioOffCommand(Radio radio)
        {
            _radio = radio;
        }

        public void Execute()
        {
            _radio.Off();
        }

        public void Undo()
        {
            _radio.On();
        }
    }
}
