using System;

namespace _10.PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int targets = 0;
            double halfPower = pokePower / 2.0;

            while (pokePower >= distance)
            {

                pokePower -= distance;
                targets++;

                if (pokePower == halfPower && exhaustionFactor > 0)
                {
                    pokePower /= exhaustionFactor;
                }

            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targets);
        }
    }
}
