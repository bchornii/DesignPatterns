﻿using System.Collections.Generic;

namespace _03_Flyweight_Character
{
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