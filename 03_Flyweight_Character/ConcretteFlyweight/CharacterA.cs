using System;

namespace _03_Flyweight_Character
{
    public class CharacterA : Character
    {
        public CharacterA()
        {
            Symbol = 'A';
            Height = 100;
            Width = 120;
            Ascent = 70;
            Descent = 0;
        }

        public override void Display(int pointSize)
        {
            PointSize = pointSize;
            Console.WriteLine($"Symbol {Symbol} (point size = {PointSize})");
        }
    }
}