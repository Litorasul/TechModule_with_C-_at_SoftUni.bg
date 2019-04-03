using System;

namespace _03.ZigZagArrays
{
    class ZigZagArrays
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            string[] firstArray = new string[lines];
            string[] secondArray = new string[lines];

            for (int i = 0; i < lines; i++)
            {
                if (i % 2 == 0)
                {
                    string input = Console.ReadLine();
                    string[] help = input.Split();
                    firstArray[i] = help[0];
                    secondArray[i] = help[1];
                }
                else
                {
                    string input = Console.ReadLine();
                    string[] help = input.Split();
                    firstArray[i] = help[1];
                    secondArray[i] = help[0];
                }

            }

            foreach (var item in firstArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in secondArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
