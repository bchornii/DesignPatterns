using System.Collections.Generic;

namespace _01_Memento_hero
{
    public class GameHistory
    {
        public Stack<HeroMemento> Store { get; }
        public GameHistory()
        {
            Store = new Stack<HeroMemento>();
        }
    }
}
