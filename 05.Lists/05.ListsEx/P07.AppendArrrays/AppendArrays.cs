using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.AppendArrrays
{
    class AppendArrays
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                int[] result = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray() ;

                Console.Write(string.Join(" ", result));
                Console.Write(" ");
            }

        }
    }
}
