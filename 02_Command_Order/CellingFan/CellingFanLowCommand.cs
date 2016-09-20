namespace _02_Command_Order
{
    public class CellingFanLowCommand : ICommand
    {
        private readonly CellingFan _cellingFan;
        private Speed _prevSpeed;

        public CellingFanLowCommand(CellingFan cellingFan)
        {
            _cellingFan = cellingFan;
        }

        public void Execute()
        {
            _prevSpeed = _cellingFan.FanSpeed;
            _cellingFan.SetLow();
        }

        public void Undo()
        {
            _cellingFan.SetCustom(_prevSpeed);
        }
    }
}