namespace _02_Command_Order
{
    public class GarageDoorOpenCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.OpenDoor();
        }

        public void Undo()
        {
            _garageDoor.CloseDoor();
        }
    }

    public class GarageDoorCloseCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.CloseDoor();
        }

        public void Undo()
        {
            _garageDoor.OpenDoor();
        }
    }
}
