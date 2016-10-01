namespace _03_Composite_Menu
{
    public class Waitress
    {
        private readonly IMenuComponent _allMenues;

        public Waitress(IMenuComponent allMenues)
        {
            _allMenues = allMenues;
        }

        public void PrintMenu()
        {
            _allMenues.Print();
        }
    }
}
