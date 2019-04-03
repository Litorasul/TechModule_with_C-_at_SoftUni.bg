using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int uselessCounter = int.Parse(Console.ReadLine());
            List<string> input = Console.ReadLine().Split("-").ToList();
            List<Team> theTeams = new List<Team>();
            List<string> teamNames = new List<string>();
            List<string> peopleSigned = new List<string>();

            while (input[0] != "end of assignment")
            {
                if (input[1].StartsWith(">"))
                {
                    input[1].TrimStart('>');
                    if (teamNames.Contains(input[1]) && !peopleSigned.Contains(input[0]))
                    {
                        int index = theTeams.IndexOf(input[1]); 
                    }
                    else if (peopleSigned.Contains(input[0]))
                    {
                        Console.WriteLine($"Member {input[0]} cannot join team {input[1]}!");
                    }
                    else if (!teamNames.Contains(input[1]))
                    {
                        Console.WriteLine($"Team {input[1]} does not exist!");
                    }
                   
                }
                else
                {
                    if (teamNames.Contains(input[1]))
                    {
                        Console.WriteLine($"Team {input[1]} was already created!");
                    }
                    else if (peopleSigned.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} cannot create another team!");
                    }
                    else
                    {

                    }
                }
            }


        }
    }

    public class Team
    {
        public string TeamName;
        public string Creator;

        public Team()
        {
            Members = new List<string>();
        }

        public List<string> Members { get; set; }

        public override string ToString()
        {
            string toPrint = $"{TeamName}"
                + Environment.NewLine
                + $"- {Creator}"
                + Environment.NewLine
                +"-- "
                + string.Join(Environment.NewLine + "-- ", Members);
            return toPrint;
        }
    }
}
