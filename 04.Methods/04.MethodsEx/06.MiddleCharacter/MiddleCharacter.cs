using System;

namespace _06.MiddleCharacter
{
    class MiddleCharacter
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleCharacter(input);
        }

        private static void PrintMiddleCharacter(string input)
        {
            char[] midd = input.ToCharArray();
            if (midd.Length % 2 != 0)
            {
                Console.WriteLine(midd[midd.Length / 2]);
            }
            else
            {
                char char1 = midd[midd.Length / 2 - 1];
                char char2 = midd[midd.Length / 2];
                Console.WriteLine($"{char1}{char2}");
            }
        }
    }
}
