using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> commandToList = command.Split().ToList();

                if (commandToList[0] == "Delete")
                {
                    int toDelete = int.Parse(commandToList[1]);
                    inputList.RemoveAll(x => x == toDelete);
                }
                else if (commandToList[0] == "Insert")
                {
                    int toAdd = int.Parse(commandToList[1]);
                    int index = int.Parse(commandToList[2]);

                    inputList.Insert(index, toAdd);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", inputList));

        }
    }
}
