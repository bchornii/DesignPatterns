using System;

namespace _03_Flyweight_Character
{
    public class CharacterZ : Character
    {
        public CharacterZ()
        {
            Symbol = 'Z';
            Height = 100;
            Width = 100;
            Ascent = 68;
            Descent = 0;
        }

        public override void Display(int pointSize)
        {
            PointSize = pointSize;
            Console.WriteLine($"Symbol {Symbol} (point size = {PointSize})");
        }
    }
}