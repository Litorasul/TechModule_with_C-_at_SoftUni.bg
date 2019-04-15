using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.TheFinalQuest
{
    class TheFinalQuest
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commandArray = command.Split().ToArray();
                string action = commandArray[0];

                switch (action)
                {
                    case "Delete": // Delete {index} – removes the word after
                                   //the given index if it is valid.
                        int index = int.Parse(commandArray[1]);
                        if (index + 1 < input.Count && index + 1 >= 0)
                        {
                            input.RemoveAt(index + 1);
                        }
                        break;


                    case "Swap": //Swap {word1} {word2} – find the given words in 
                                 //the collections if they exist and swap their places.
                        string wordOne = commandArray[1];
                        string wordTwo = commandArray[2];

                        if (input.Contains(wordOne) && input.Contains(wordTwo))
                        {
                            int indexOne = input.IndexOf(wordOne);
                            int indexTwo = input.IndexOf(wordTwo);

                            string temp = input[indexOne];
                            input[indexOne] = input[indexTwo];
                            input[indexTwo] = temp;
                        }
                        break;

                    case "Put": //Put {word} {index} – add a word at the previous place {index}  
                                //before the given one, if it exists.
                        string word = commandArray[1];
                        int indexPut = int.Parse(commandArray[2]);
                        if (indexPut - 1 < input.Count && indexPut - 1 >= 0)
                        {
                            input.Insert(indexPut - 1, word);
                        }
                        break;


                    case "Sort": //Sort – you must sort the words in descending order.
                        input.Sort((x, y) => y.CompareTo(x));
                        break;

                    case "Replace": //Replace { word1} { word2} – find the second word { word2} 
                        //in the collection(if it exists) and replace it with the first word – { word1}.
                        string word1 = commandArray[1];
                        string word2 = commandArray[2];

                        if (input.Contains(word2))
                        {
                            int indexOf = input.IndexOf(word2);
                            input[indexOf] = word1;
                        }
                        break;

                }              
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
