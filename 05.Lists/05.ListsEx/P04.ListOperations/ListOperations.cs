using System;
using System.Linq;
using System.Collections.Generic;

namespace P04.ListOperations
{
    class ListOperations
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "End")
            {
                bool indexIsRight = false;


                if (command[0] == "Add")
                {
                    inputList.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    indexIsRight = IsIndexIn(inputList, int.Parse(command[2]));
                    if (indexIsRight)
                    {
                        inputList.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[0] == "Remove")
                {
                    indexIsRight = IsIndexIn(inputList, int.Parse(command[1]));
                    if (indexIsRight)
                    {
                        inputList.RemoveAt(int.Parse(command[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[1] == "left")
                {
                    int count = int.Parse(command[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int temp = inputList[0];
                        inputList.Add(temp);
                        inputList.RemoveAt(0); 
                    }

                }
                else if (command[1] == "right")
                {
                    int count = int.Parse(command[2]);
                    for (int j = 0; j < count; j++)
                    {
                        int temp = inputList[inputList.Count - 1];
                        inputList.Insert(0, temp);
                        inputList.RemoveAt(inputList.Count - 1);

                    }
                }
                command = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(string.Join(" ",inputList));
        }

        private static bool IsIndexIn(List<int> inputList, int index)
        {
            if (index < inputList.Count && index >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
