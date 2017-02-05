using System;
using System.Collections.Generic;

namespace _03_Flyweight_Character
{
    internal class Program
    {
        private static void Main()
        {
            const string document = "AAZZBBAZ";
            var chars = document.ToCharArray();

            var factory = new CharacterFactory();

            // extrinsic state
            var pointSize = 10;

            // For each character use flyweight object
            foreach (var c in chars)
            {
                pointSize++;
                var character = factory.GetCharacter(c);
                character.Display(pointSize);
            }

            Console.WriteLine($"Total objects = {factory.TotalFlyweightObjects}");

            Console.Read();
        }
    }

    public abstract class Character
    {
        protected char Symbol;
        protected int Width;
        protected int Height;
        protected int Ascent;
        protected int Descent;
        protected int PointSize;

        public abstract void Display(int pointSize);
    }

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

    public class CharacterFactory
    {
        private readonly IDictionary<char, Character> _characters = new Dictionary<char, Character>();

        public int TotalFlyweightObjects => _characters.Count;

        public Character GetCharacter(char key)
        {
            Character character = null;
            if (_characters.ContainsKey(key))
            {
                character = _characters[key];
            }
            else
            {
                switch (key)
                {
                    case 'A': character = new CharacterA();
                        break;
                    case 'B': character = new CharacterB();
                        break;
                    case 'Z': character = new CharacterZ();
                        break;
                }
                _characters.Add(key, character);
            }
            return character;
        }
    }
}
