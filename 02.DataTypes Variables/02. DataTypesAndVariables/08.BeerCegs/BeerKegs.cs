using System;

namespace _08.BeerCegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegsNumber = int.Parse(Console.ReadLine());
            string biggestKeg = String.Empty;
            double biggestVolume = 0;

            for (int i = 0; i < kegsNumber; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double singleKegVolume = Math.PI * radius * radius * height;

                if (singleKegVolume > biggestVolume)
                {
                    biggestVolume = singleKegVolume;
                    biggestKeg = model;
                }
            }

            Console.WriteLine(biggestKeg);

        }
    }
}
