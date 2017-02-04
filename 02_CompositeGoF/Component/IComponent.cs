namespace _02_CompositeGoF
{
    public interface IComponent
    {
        string GatherData();
        void Add(IComponent component);
        void Remove(IComponent component);
        IComponent GetChild(int index);        
    }
}
