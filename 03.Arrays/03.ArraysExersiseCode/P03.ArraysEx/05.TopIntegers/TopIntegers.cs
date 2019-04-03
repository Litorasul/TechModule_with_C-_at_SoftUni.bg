using System;
using System.Linq;

namespace _05.TopIntegers
{
    class TopIntegers
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            for (int i = 0; i < numArray.Length; i++)
            {
                bool isBigger = true;

                for (int j = i + 1; j < numArray.Length; j++)
                {
                    if (numArray[i] <= numArray[j])
                    {
                        isBigger = false;
                    } 
                }
                if (isBigger)
                {
                    Console.Write(numArray[i] + " ");
                }

            }

        }
    }
}
