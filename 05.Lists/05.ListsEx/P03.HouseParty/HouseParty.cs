using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.HouseParty
{
    class HouseParty
    {
        static void Main(string[] args)
        {
            int commandsAmmount = int.Parse(Console.ReadLine());

            List<string> goingToTheParty = new List<string>();

            for (int i = 0; i < commandsAmmount; i++)
            {
                List<string> command = Console.ReadLine()
                    .Split()
                    .ToList();

                bool isAlreadyIn = IsItIn(goingToTheParty, command);

                if (command.Count == 3)
                {
                    if (isAlreadyIn)
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        goingToTheParty.Add(command[0]);
                    }
                }
                else
                {
                    if (isAlreadyIn)
                    {
                        goingToTheParty.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }

            foreach (var item in goingToTheParty)
            {
                Console.WriteLine(item);
            }
        }

        private static bool IsItIn(List<string> goingToTheParty, List<string> command)
        {
            for (int j = 0; j < goingToTheParty.Count; j++)
            {
                if (goingToTheParty[j] == command[0])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
