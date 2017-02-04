namespace _03_Composite_Menu
{
    public interface IMenuComposite : IMenuComponent
    {
        void Add(IMenuComponent menuComponent);
        void Remove(IMenuComponent menuComponent);
        IMenuComponent GetChild(int i);
    }
}