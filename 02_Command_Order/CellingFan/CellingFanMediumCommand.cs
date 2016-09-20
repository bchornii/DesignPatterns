namespace _02_Command_Order
{
    public class CellingFanMediumCommand : ICommand
    {
        private readonly CellingFan _cellingFan;
        private Speed _prevSpeed;

        public CellingFanMediumCommand(CellingFan cellingFan)
        {
            _cellingFan = cellingFan;
        }

        public void Execute()
        {
            _prevSpeed = _cellingFan.FanSpeed;
            _cellingFan.SetMedium();
        }

        public void Undo()
        {
            _cellingFan.SetCustom(_prevSpeed);
        }
    }
}
