namespace _02_Command_Order
{
    public class CellingFanHighCommand : ICommand
    {
        private readonly CellingFan _cellingFan;
        private Speed _prevSpeed;
        public CellingFanHighCommand(CellingFan cellingFan)
        {
            _cellingFan = cellingFan;
        }

        public void Execute()
        {
            _prevSpeed = _cellingFan.FanSpeed;
            _cellingFan.SetHigh();
        }

        public void Undo()
        {
            _cellingFan.SetCustom(_prevSpeed);
        }
    }
}
