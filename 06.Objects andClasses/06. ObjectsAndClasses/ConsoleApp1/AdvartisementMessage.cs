using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class AdvartisementMessage
    {
        static void Main(string[] args)
        {
            int ammount = int.Parse(Console.ReadLine());

            CreateAndPrint(ammount);
        }

        private static void CreateAndPrint(int ammount)
        {
            var phrases = new List<string> { "Excellent product.",
               "Such a great product.",
               "I always use that product.",
               "Best product of its category.",
               "Exceptional product.",
               "I can’t live without this product." };

            var events = new List<string> { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };

            var authors = new List<string> { "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva" };

            var cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < ammount; i++)
            {
                Random index = new Random();
                string[] message = new string[4];
                message[0] = phrases[index.Next(1, 6)];
                message[1] = events[index.Next(1, 6)];
                message[2] = authors[index.Next(1, 8)];
                message[3] = cities[index.Next(1, 5)];

                Console.WriteLine($"{message[0]} {message[1]} {message[2]} – {message[3]}");

            }
        }
    }
}
