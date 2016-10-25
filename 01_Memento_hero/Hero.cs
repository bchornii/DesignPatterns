using System;

namespace _01_Memento_hero
{
    public class Hero
    {
        private int _pattrons = 10;
        private int _lives = 5;

        public void Shot()
        {
            if (_pattrons > 0)
            {
                _pattrons--;
                Console.WriteLine($"Make shot. Remains {_pattrons}");
            }
            else
            {
                Console.WriteLine("You hace no pattrons");
            }
        }

        public HeroMemento SaveState()
        {
            Console.WriteLine($"Game saving. Parameters : {_pattrons} pattrons, {_lives} lives");
            return new HeroMemento(_pattrons, _lives);
        }

        public void RestoreState(HeroMemento memento)
        {
            _pattrons = memento.Pattrons;
            _lives = memento.Lives;
            Console.WriteLine($"Game restores. Parameters : {_pattrons} pattrons, {_lives} lives");
        }
    }
}
