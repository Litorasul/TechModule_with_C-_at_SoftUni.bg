using System;
using System.Linq;

namespace _08.MagicSum
{
    class MagicSum
    {
        static void Main(string[] args)
        {
            int[] magicArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int magicNumber = int.Parse(Console.ReadLine());


            for (int i = 0; i < magicArr.Length - 1; i++)
            {
                for (int j = i + 1; j < magicArr.Length; j++)
                {
                    if (magicArr[i] + magicArr[j] == magicNumber)
                    {
                        Console.WriteLine(magicArr[i] + " " + magicArr[j]);
                    }
                }
                
            }

        }
    }
}
