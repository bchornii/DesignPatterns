namespace _02_Command_Order
{
    public class CellingFanOffCommand : ICommand
    {
        private readonly CellingFan _cellingFan;
        private Speed _prevSpeed;

        public CellingFanOffCommand(CellingFan cellingFan)
        {
            _cellingFan = cellingFan;
        }

        public void Execute()
        {
            _prevSpeed = _cellingFan.FanSpeed;
            _cellingFan.SetOff();
        }

        public void Undo()
        {
            _cellingFan.SetCustom(_prevSpeed);
        }
    }
}