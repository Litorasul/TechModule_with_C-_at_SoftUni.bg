using System;

namespace _02.SumDigits
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int number = input[i] - '0';
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
