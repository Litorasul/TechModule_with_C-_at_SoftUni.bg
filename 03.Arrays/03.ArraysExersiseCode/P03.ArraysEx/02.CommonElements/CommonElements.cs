using System;
using System.Linq;

namespace _02.CommonElements
{
    class CommonElements
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            string[] firstArray = firstInput.Split();
            string[] secondArray = secondInput.Split();

            var common = secondArray.Intersect(firstArray);

            foreach (var item in common)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
    }
}
