using System;

namespace _08.FactorialDivision
{
    class FactorialDivision
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            double factorialFirst = CalculateFactorial(first);
            double factorialSecond = CalculateFactorial(second);

            double result = DevideResults(factorialFirst, factorialSecond);

            Console.WriteLine($"{result:F2}");
        }

        private static double DevideResults(double factorialFirst, double factorialSecond)
        {
            double devRes = factorialFirst / factorialSecond;
            return devRes;
        }

        private static double CalculateFactorial(int number)
        {
            double calcRes = 1;

            for (int i = 1; i <= number; i++)
            {
                calcRes *= i;
            }

            return calcRes;
        }
    }
}
