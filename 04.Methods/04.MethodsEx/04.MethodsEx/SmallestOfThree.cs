using System;
using System.Linq;

namespace _04.MethodsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            SmallesOutOfThree(firstNumber, secondNumber, thirdNumber);
        }

        private static void SmallesOutOfThree(int firstNumber, int secondNumber, int thirdNumber)
        {
            int[] numbers = new int[] { firstNumber, secondNumber, thirdNumber };
            int smallestNumber = numbers.Min();
            Console.WriteLine(smallestNumber);
        }
    }
}
