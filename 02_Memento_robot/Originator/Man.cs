namespace _02_Memento_robot
{
    public class Man
    {
        public string State { get; set; }

        public void SetMemento(IMementoNarrowInterface backpack)
        {
            State = (backpack as IMementoWideInterface<string>)?.GetState();
        }

        public IMementoNarrowInterface CreateMenento()
        {
            return new Backpack(State);
        }
    }
}
