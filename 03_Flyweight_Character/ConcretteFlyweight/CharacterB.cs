using System;

namespace _03_Flyweight_Character
{
    public class CharacterB : Character
    {
        // Constructor
        public CharacterB()
        {
            Symbol = 'B';
            Height = 100;
            Width = 140;
            Ascent = 72;
            Descent = 0;
        }

        public override void Display(int pointSize)
        {
            PointSize = pointSize;
            Console.WriteLine($"Symbol {Symbol} (point size = {PointSize})");
        }

    }
}