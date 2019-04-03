using System;

namespace _05.AddSubstract
{
    class AddSubstract
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int firstResult = sum(first, second);
            int result = Substract(firstResult, third);

            Console.WriteLine(result);


        }

        private static int Substract(int firstResult, int third)
        {
            int res2 = firstResult - third;
            return res2;
        }

        private static int sum(int first, int second)
        {
            int res = first + second;
            return res;
        }
    }
}
