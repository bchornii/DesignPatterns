namespace _01_Memento_hero
{
    public class HeroMemento
    {
        public int Pattrons { get; }
        public int Lives { get; }

        public HeroMemento(int pattrons, int lives)
        {
            Pattrons = pattrons;
            Lives = lives;
        }        
    }
}
