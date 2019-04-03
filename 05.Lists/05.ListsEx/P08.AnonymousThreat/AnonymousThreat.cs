using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    MergeData(data, command);
                }
                else if (command [0]== "divide")
                {
                    DevideData(data, command);
                }
            }
        }

        private static void DevideData(List<string> data, List<string> command)
        {
            throw new NotImplementedException();
        }

        private static void MergeData(List<string> data, List<string> command)
        {
            if (int.Parse(command[1]) < data.Count && int.Parse(command[2]) < data.Count)
            {
                data[int.Parse(command[1])] += data[int.Parse(command[2])];
                data.RemoveAt(int.Parse(command[2]));
            }
        }
    }
}
