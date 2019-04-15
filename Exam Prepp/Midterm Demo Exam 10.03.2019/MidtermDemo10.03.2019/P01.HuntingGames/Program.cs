using System;

namespace P01.HuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double waterPerPerson = double.Parse(Console.ReadLine());
            double foodPerPerson = double.Parse(Console.ReadLine());

            double totalWater = days * players * waterPerPerson;
            double totalFood = days * players * foodPerPerson;

            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());

                if (energy - energyLoss <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:F2} food and {totalWater:F2} water.");
                    return;
                }

                
                energy -= energyLoss;
               

                if (i % 2 == 0)
                {
                    energy *= 1.05;
                    totalWater -= totalWater * 0.3;
                }

                if (i % 3 == 0)
                {
                    energy *= 1.1;
                    totalFood -= totalFood / players;
                }  

            }

            if (energy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:F2} energy!");
            }          


        }
    }
}
