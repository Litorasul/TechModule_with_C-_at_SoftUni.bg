using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Shopping
{
    class Shopping
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                string action = command[0];
                if (action == "Include")
                {
                    //Include {shop}
                    string shop = command[1];
                    if (shop != string.Empty)
                    {
                        input.Add(shop);
                    }
                }
                else if (action == "Visit")
                {
                    //Visit {first/last} {numberOfShops}
                    string topBottom = command[1];
                    int number = int.Parse(command[2]);
                    if (topBottom == "first")
                    {
                        if (number - 1 < input.Count && number >= 0)
                        {
                            input.RemoveRange(0, number);
                        }
                    }
                    else if (topBottom == "last")
                    {
                        if (input.Count - number >= 0)
                        {
                            int index = input.Count - number;
                            input.RemoveRange(index, number);

                        }
                    }
                }
                else if (action == "Prefer")
                {
                    //Prefer {shopIndex1} {shopIndex2}
                    int first = int.Parse(command[1]);
                    int second = int.Parse(command[2]);

                    if (first < input.Count 
                        && second < input.Count 
                        && first >= 0 && second >=0 && first != second)
                    {
                        string temp = input[first];
                        input[first] = input[second];
                        input[second] = temp;
                    }
                }
                else if (action == "Place")
                {
                    //Place {shop} {shopIndex}
                    string shop = command[1];
                    int index = int.Parse(command[2]);

                    if (index + 1 < input.Count && index + 1 >= 0)
                    {
                        input.Insert(index + 1, shop);
                    }
                }
            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
