using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Dictionarys
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" | ").ToArray();

            //the Key is the word the Value is a list with definitions.
            var wordDefinition = new Dictionary<string, List<string>>();

            foreach (var item in input)
            {
                string[] inputArray = item.Split(": ").ToArray();
                string word = inputArray[0];
                string definition = inputArray[1];

                if (wordDefinition.ContainsKey(word))
                {
                    wordDefinition[word].Add(definition);
                }
                else
                {
                    wordDefinition.Add(word, new List<string>());
                    wordDefinition[word].Add(definition);
                }
            }

            input = Console.ReadLine().Split(" | ").ToArray();
            foreach (var word in input)
            {
                if (wordDefinition.ContainsKey(word))
                {
                    Console.WriteLine($"{word}");
                    foreach (var definition in wordDefinition[word].OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine($" -{definition}");
                    }
                }
            }
            string finalInput = Console.ReadLine();
            if (finalInput == "End")
            {
                return;
            }
            else
            {
                foreach (var word in wordDefinition.OrderBy(g => g.Key))
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
