using System;
using System.Linq;

namespace _10.TopNumber
{
    class TopNumber
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            TopNumberCheck(input);
        }

        private static void TopNumberCheck(int input)
        {

            for (int i = 1; i <= input; i++)
            {
                int sum = 0;
                bool oddDigit = false;
                int cpy = i;
                while (true)
                {
                    if (cpy == 0) break;
                    int right = cpy % 10;
                    sum += right;
                    if (!(right % 2 == 0)) oddDigit = true;
                    cpy /= 10;
                }
                if (sum % 8 == 0 && oddDigit == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
