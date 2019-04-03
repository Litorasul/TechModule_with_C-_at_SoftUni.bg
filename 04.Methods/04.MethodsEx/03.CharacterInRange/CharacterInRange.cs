using System;

namespace _03.CharacterInRange
{
    class CharacterInRange
    {
        static void Main(string[] args)
        {
            char rangeStart = char.Parse(Console.ReadLine());
            char rangeEnd = char.Parse(Console.ReadLine());

            WhatIsInRange(rangeStart, rangeEnd);
        }

        private static void WhatIsInRange(char rangeStart, char rangeEnd)
        {
            if (rangeStart < rangeEnd)
            {
                for (int i = rangeStart + 1; i < rangeEnd; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = rangeEnd + 1; i < rangeStart; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
