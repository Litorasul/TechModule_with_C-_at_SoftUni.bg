using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Train
{
    class Train
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                List<string> inputList = input.Split().ToList();

                if (inputList.Count >= 2)
                {
                    train.Add(int.Parse(inputList[1]));
                }
                else
                {
                    for (int i = 0; i < train.Count; i++)
                    {
                        int toAdd = int.Parse(inputList[0]);
                        if (train[i] < wagonCapacity 
                            && (train[i] + toAdd) <= wagonCapacity)
                        {
                            train[i] += toAdd;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",train));
        }
    }
}
