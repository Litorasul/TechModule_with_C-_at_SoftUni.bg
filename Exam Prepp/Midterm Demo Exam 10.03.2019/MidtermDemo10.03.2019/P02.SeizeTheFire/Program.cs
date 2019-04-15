using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.SeizeTheFire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fireInput = Console.ReadLine().Split("#").ToArray();
            int water = int.Parse(Console.ReadLine());

            List<int> cells = new List<int>();
            double effort = 0.0;
            int totalFire = 0;

            for (int i = 0; i < fireInput.Length; i++)
            {
                string[] currentFire = fireInput[i].Split(" = ").ToArray();
                string fireType = currentFire[0];
                int fireValue = int.Parse(currentFire[1]);

                switch (fireType)
                {
                    case "High":
                        if (fireValue >= 81 && fireValue <= 125 && water >= fireValue)
                        {
                            totalFire += fireValue;
                            effort += fireValue * 0.25;
                            cells.Add(fireValue);
                            water -= totalFire;
                        }
                        break;
                    case "Medium":
                        if (fireValue >= 51 && fireValue <= 80 && water >= fireValue)
                        {
                            totalFire += fireValue;
                            effort += fireValue * 0.25;
                            cells.Add(fireValue);
                            water -= totalFire;
                        }
                        break;
                    case "Low":
                        if (fireValue >= 1 && fireValue <= 50 && water >= fireValue)
                        {
                            totalFire += fireValue;
                            effort += fireValue * 0.25;
                            cells.Add(fireValue);
                            water -= totalFire;
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Cells:");
            foreach (var item in cells)
            {
                Console.WriteLine($"- {item}");
            }
            Console.WriteLine($"Effort: {effort:F2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
