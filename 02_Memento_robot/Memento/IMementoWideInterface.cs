namespace _02_Memento_robot
{
    public interface IMementoWideInterface<T> : IMementoNarrowInterface
    {
        T GetState();
        void SetState(T state);
    }
}