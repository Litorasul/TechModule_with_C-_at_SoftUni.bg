using System;

namespace _01.Trains
{
    class Trains
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] passengers = new int[wagons];
            int sum = 0;

            for (int i = 0; i < wagons; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                sum += passengers[i];
                
            }
            foreach (var item in passengers)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);

        }
          
    }
}
