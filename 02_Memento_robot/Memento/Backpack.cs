namespace _02_Memento_robot
{
    public class Backpack : IMementoWideInterface<string>
    {
        private string _state;

        public Backpack(string state)
        {
            SetState(state);
        }

        public string GetState()
        {
            return _state;
        }

        public void SetState(string state)
        {
            _state = state;
        }
    }
}