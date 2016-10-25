namespace _02_Memento_robot
{
    public class Man
    {
        public string State { get; private set; }

        public Man()
        {
            State = "T-Shirt, jeans, keds";
        }

        public void ChangeClose()
        {
            State = "Shorts";
        }

        public void Dress(IBackpackNarrowInterface backpack)
        {
            State = (backpack as IBackpackWideInterface<string>)?.GetState();
        }

        public IBackpackNarrowInterface Undress()
        {
            return new Backpack(State);
        }
    }
}
