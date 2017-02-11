using System;

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
}
