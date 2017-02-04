namespace _03_Composite_Menu
{
    public interface IMenuComponent
    {
        string GetName();
        string GetDescription();
        double GetPrice();
        bool IsVegeterian();
        void Print();
    }
}
