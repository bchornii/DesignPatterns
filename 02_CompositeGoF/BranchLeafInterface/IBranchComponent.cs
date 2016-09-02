namespace _02_CompositeGoF
{
    interface IBranchComponent : IComponent
    {
        void Add(IComponent component);
        void Remove(IComponent component);
        IComponent GetChild(int index);
    }
}
