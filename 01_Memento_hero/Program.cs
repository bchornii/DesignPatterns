using System;

namespace _01_Memento_hero
{
    internal class Program
    {
        private static void Main()
        {
            var hero = new Hero();
            var history = new GameHistory();
            hero.Shot();

            history.Store.Push(hero.SaveState());

            hero.Shot();

            hero.RestoreState(history.Store.Pop());

            hero.Shot();

            Console.Read();
        }
    }
}
