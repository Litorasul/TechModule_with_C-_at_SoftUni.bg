using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Gifts
{
    class Gifts
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "No Money")
            {
                string[] commandArray = command.Split().ToArray();
                string action = commandArray[0];

                if (action == "OutOfStock")
                {
                    //OutOfStock {gift}
                    string gift = commandArray[1];
                    while (input.Contains(gift))
                    {
                        int index = input.IndexOf(gift);
                        input[index] = "none";
                    }

                }
                else if (action == "Required")
                {
                    //Required {gift} {index}
                    string gift = commandArray[1];
                    int index = int.Parse(commandArray[2]);
                    if (index < input.Count && index >= 0)
                    {
                        input.RemoveAt(index);
                        input.Insert(index, gift);
                    }
                }
                else if (action == "JustInCase")
                {
                    //JustInCase {gift}
                    string gift = commandArray[1];

                    input.RemoveAt(input.Count -1);
                    input.Add(gift);
                }
            }

            foreach (var item in input)
            {
                if (item != "none")
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
