using System;
using System.Linq;

namespace _07.MaxSequenceEqualElements
{
    class MaxSequenceEqualElements
    {
        static void Main(string[] args)
        {
            int[] sequenceArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxIndex = 0;
            int maxSize = 1;

            int workIndex = 0;
            int workSize = 1;

            for (int i = 0; i < sequenceArr.Length - 1; i++)
            {
                if (sequenceArr[i] == sequenceArr[i + 1])
                {
                    workIndex = sequenceArr[i];
                    workSize++;
                }
                else
                {
                    workIndex = 0;
                    workSize = 1;
                }

                if (workSize > maxSize)
                {
                    maxSize = workSize;
                    maxIndex = workIndex;
                }
            }
            for (int j = 0; j < maxSize; j++)
            {
                Console.Write(maxIndex + " ");
            }
        }
    }
}
