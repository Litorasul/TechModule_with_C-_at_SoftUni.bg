using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Judge
{
    class Judge
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            //first Key is the contest, second Key is the participant the Value is the most points
            var contestNamePoints = new Dictionary<string, Dictionary<string, int>>();

            //the Key is the participant the Value is the total of his points
            var nameTotalPoints = new Dictionary<string, int>();

            while ((input=Console.ReadLine()) != "no more time")
            {
                //input format: {username} -> {contest} -> {points}
                string[] inputArray = input.Split(" -> ").ToArray();
                string name = inputArray[0];
                string contest = inputArray[1];
                int points = int.Parse(inputArray[2]);

                if (contestNamePoints.ContainsKey(contest))
                {
                    if (contestNamePoints[contest].ContainsKey(name))
                    {
                        if (contestNamePoints[contest][name] < points)
                        {
                            contestNamePoints[contest][name] = points;
                        }
                    }
                    else
                    {
                        contestNamePoints[contest].Add(name, points);
                    }
                }
                else
                {
                    contestNamePoints.Add(contest, new Dictionary<string, int>());
                    contestNamePoints[contest].Add(name, points);
                }

                if (nameTotalPoints.ContainsKey(name))
                {
                    nameTotalPoints[name] += points;
                }
                else
                {
                    nameTotalPoints.Add(name, points);
                }
            }

            foreach (var contest in contestNamePoints)
            {
                string key = contest.Key;
                int count = contestNamePoints[key].Count();
                Console.WriteLine($"{contest.Key}: {count} participants");
                foreach (var participant in contestNamePoints[key].OrderByDescending(x=>x.Value).ThenBy(s=>s.Key))
                {
                    int i = 1;
                    Console.WriteLine($"{i}. {participant.Key} <::> {participant.Value}");
                    i++;
                }
            }

            Console.WriteLine("Individual standings:");
            foreach (var name in nameTotalPoints.OrderByDescending(g=>g.Value).ThenBy(h=>h.Key))
            {
                int i = 1;
                Console.WriteLine($"{i}. {name.Key} -> {name.Value}");
                i++;
            }
        }
    }
}
