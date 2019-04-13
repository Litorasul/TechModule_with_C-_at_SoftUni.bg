using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Concert
{
    class Concert
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var bandMembers = new Dictionary<string, List<string>>();
            var bandTime = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "start of concert")
            {
                var inputArray = input.Split("; ").ToArray();
                string command = inputArray[0];

                if (command == "Add")
                {
                    //Add; {bandName}; {member 1}, {member 2}, {member 3}

                    string bandName = inputArray[1];
                    List<string> members = inputArray[2].Split(", ").ToList();
                    if (bandMembers.ContainsKey(bandName))
                    {
                        foreach (var member in members)
                        {
                            if (!bandMembers[bandName].Contains(member))
                            {
                                bandMembers[bandName].Add(member);
                            }
                        }
                    }
                    else
                    {
                        bandMembers[bandName] = new List<string>();
                        foreach (var member in members)
                        {
                            bandMembers[bandName].Add(member);
                        }
                    }
                }
                else
                {
                    //Play; {bandName}; {time}
                    string bandName = inputArray[1];
                    int time = int.Parse(inputArray[2]);

                    if (!bandMembers.ContainsKey(bandName))
                    {
                        bandMembers[bandName] = new List<string>();
                    }

                    if (bandTime.ContainsKey(bandName))
                    {
                        bandTime[bandName] += time;
                    }
                    else
                    {
                        bandTime[bandName] = time;
                    }
                }
            }

            int totalTime = 0;

            foreach (var band in bandTime)
            {
                totalTime += band.Value;
            }

            Console.WriteLine($"Total time: {totalTime}");
            foreach (var band in bandTime.OrderByDescending(x => x.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            input = Console.ReadLine();
            Console.WriteLine(input);
            foreach (var member in bandMembers[input])
            {
                Console.WriteLine($"=> {member}");
            }
        }
    }
}
