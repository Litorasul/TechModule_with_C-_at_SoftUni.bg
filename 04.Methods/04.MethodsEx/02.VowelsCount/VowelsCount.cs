using System;
using System.Linq;

namespace _02.VowelsCount
{
    class VowelsCount
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            VowelsCounter(input);
        }

        private static void VowelsCounter(string input)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', };

            int total = input.Count(x => vowels.Contains(x));

            Console.WriteLine(total);

        }
    }
}
