using System;

namespace P01.Cozonacs
{
    class Cozonacs
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double kiloFlour = double.Parse(Console.ReadLine());

            double packEggs = kiloFlour * 0.75;
            double milkNeeded = (kiloFlour * 1.25) / 4;

            int coloredEggs = 0;

            double oneCozonac = kiloFlour + packEggs + milkNeeded;
            int readyCozonacs = 0;

            while (budget - oneCozonac > 0)
            {
                budget -= oneCozonac;
                coloredEggs += 3;
                readyCozonacs++;
                if (readyCozonacs % 3 == 0)
                {
                    coloredEggs -= readyCozonacs - 2;
                }
            }

            Console.WriteLine($"You made {readyCozonacs} cozonacs! Now you have {coloredEggs} eggs and {budget:F2}BGN left.");
        }
    }
}
