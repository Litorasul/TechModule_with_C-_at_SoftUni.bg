using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Annapurna
{
    class Annapurna
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var storeIntems = new Dictionary<string, List<string>>();

            while ((input= Console.ReadLine()) != "END")
            {
                string[] inputArray = input.Split("->").ToArray();
                string command = inputArray[0];
                string store = inputArray[1];
                if (command == "Add")
                {
                    
                    string[] items = inputArray[2].Split(",").ToArray();
                    if (storeIntems.ContainsKey(store))
                    {
                        foreach (var item in items)
                        {
                            storeIntems[store].Add(item);
                        }
                    }
                    else
                    {
                        storeIntems[store] = new List<string>();
                        foreach (var item in items)
                        {
                            storeIntems[store].Add(item);
                        }

                    }
                }
                else
                {
                    if (storeIntems.ContainsKey(store))
                    {
                        storeIntems.Remove(store);
                    }
                }
            }

            Console.WriteLine("Stores list:");
            foreach (var store in storeIntems.OrderByDescending(x => x.Value.Count).ThenByDescending(s => s.Key))
            {
                Console.WriteLine(store.Key);
                foreach (var item in store.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
