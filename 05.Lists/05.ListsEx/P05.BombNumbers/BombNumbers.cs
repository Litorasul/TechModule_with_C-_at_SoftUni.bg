using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> bombAndPower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            ExplodeTheBomb(numbers, bombAndPower);
            SumAndPrint(numbers);
        }

        private static void SumAndPrint(List<int> numbers)
        {
            int sum = 0;
            for (int k = 0; k < numbers.Count; k++)
            {
                sum += numbers[k];
            }
            Console.WriteLine(sum);
        }

        private static void ExplodeTheBomb(List<int> numbers, List<int> bombAndPower)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombAndPower[0])
                {
                    int start = i - bombAndPower[1];
                    if (start < 0)
                    {
                        start = 0;
                    }

                    int finish = i + bombAndPower[1] + 1;
                    if (finish > numbers.Count)
                    {
                        finish = numbers.Count;
                    }

                    for (int j = start; j < finish; j++)
                    {
                        numbers[j] = 0;
                    }
                }
            }

        }
    }
}
