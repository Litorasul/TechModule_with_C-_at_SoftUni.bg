using System;
using System.Linq;

namespace _06.EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToArray();

            bool yesSuchNumber = false;

            for (int i = 0; i < numArray.Length; i++)
            {
                int rightSum = 0;
                int leftSum = 0;

                for (int j = i+1; j < numArray.Length; j++)
                {
                    rightSum += numArray[j];
                }

                for (int k = i - 1; k >= 0; k--)
                {
                    leftSum += numArray[k];
                }
                if (rightSum == leftSum)
                {
                    yesSuchNumber = true;
                    Console.Write(i + " ");
                }
            }

            if (yesSuchNumber == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
