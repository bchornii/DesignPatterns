using System;

namespace _03_TemplateMethod_Flag
{
    public class UkrainianFlag : TwoColorFlag
    {
        protected override void DrawTopPart()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string(' ', 7));
        }

        protected override void DrawBottomPart()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string(' ', 7));
        }
    }
}