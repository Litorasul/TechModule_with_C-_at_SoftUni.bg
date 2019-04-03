using System;

namespace _07.WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int volume = 255;
            int litersInTank = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                int litersInput = int.Parse(Console.ReadLine());

                if (litersInTank + litersInput <= volume)
                {
                    litersInTank += litersInput;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(litersInTank);

        }
    }
}
