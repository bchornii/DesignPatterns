namespace _02_Memento_robot
{
    public interface IBackpackNarrowInterface
    {               
    }

    public interface IBackpackWideInterface<T> : IBackpackNarrowInterface
    {
        T GetState();
        void SetState(T state);
    }
}
