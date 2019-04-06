using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Ranking
{
    class Ranking
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var contestAndPass = new Dictionary<string, string>(); // key == contest, value == password

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] inputArray = input.Split(":").ToArray();
                string contest = inputArray[0];
                string pass = inputArray[1];

                contestAndPass.Add(contest, pass);
            }

            var nameContestPoints = new Dictionary<string, Dictionary<string, int>>();
            // ^ first Key is the Username, second Key is the contest, the Value is the Points


            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] inputArray = input.Split("=>").ToArray();
                string contest = inputArray[0];
                string pass = inputArray[1];
                string name = inputArray[2];
                int points = int.Parse(inputArray[3]);

                if (contestAndPass.ContainsKey(contest))
                {
                    if (contestAndPass[contest] == pass)
                    {
                        if (nameContestPoints.ContainsKey(name))
                        {
                            if (nameContestPoints[name].ContainsKey(contest))
                            {
                                if (nameContestPoints[name][contest] < points)
                                {
                                    nameContestPoints[name][contest] = points;
                                }
                            }
                            else
                            {
                                nameContestPoints[name].Add(contest, points);
                            }
                        }
                        else
                        {
                            nameContestPoints.Add(name, new Dictionary<string, int>());
                            nameContestPoints[name].Add(contest, points);
                        }
                    }
                }

            }

            var nameTotalPoints = new Dictionary<string, int>(); // key == username, value == total points in all contests

            foreach (var name in nameContestPoints)
            {
                int sum = 0;
                string key = name.Key;
                foreach (var contest in nameContestPoints[key])
                {
                    sum += contest.Value;
                }
                nameTotalPoints.Add(key, sum);
            }

            string winnerName = nameTotalPoints.FirstOrDefault(x => x.Value == nameTotalPoints.Values.Max()).Key;
            int winnerPoints = nameTotalPoints.FirstOrDefault(x => x.Value == nameTotalPoints.Values.Max()).Value;
            Console.WriteLine($"Best candidate is {winnerName} with total {winnerPoints} points.");
            Console.WriteLine("Ranking: ");

            foreach (var name in nameContestPoints.OrderBy(x=>x.Key))
            {
                Console.WriteLine(name.Key);
                string key = name.Key;
                
                foreach (var cource in nameContestPoints[key].OrderByDescending(c=>c.Value))
                {
                    Console.WriteLine($"#  {cource.Key} -> {cource.Value}");
                }
            }
        }
    }
}
