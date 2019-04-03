using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class ArrayRotation
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rotationCounter = int.Parse(Console.ReadLine());
          
            for (int i = 0; i < rotationCounter; i++)
            {
                int firstNumber = items[0];

                for (int j = 0; j < items.Length - 1; j++)
                {
                    items[j] = items[j + 1];
                }
                items[items.Length - 1] = firstNumber;
               
            }

            Console.WriteLine(string.Join(" ", items));
        }
    }
}
