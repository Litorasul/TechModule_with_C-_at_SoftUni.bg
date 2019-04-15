using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.VaporWinterSale
{
    class VaporWinterSale
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").ToArray();
            var gamePrice = new Dictionary<string, double>();
            var gameDlc = new Dictionary<string, string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Contains(':'))
                {
                    // {game}:{DLC}
                    string[] toArray = input[i].Split(":").ToArray();
                    string game = toArray[0];
                    string dlc = toArray[1];

                    if (gamePrice.ContainsKey(game))
                    {
                        gamePrice[game] *= 1.2;
                        gameDlc[game] = dlc;
                    }
                }
                else
                {
                    // {game}-{price}
                    string[] toArray = input[i].Split("-").ToArray();
                    string game = toArray[0];
                    double price = double.Parse(toArray[1]);
                    gamePrice[game] = price;

                }
            }
            var gameFinalPrice = new Dictionary<string, double>();
            var dlcFinalPrice = new Dictionary<string, double>();
            foreach (var game in gamePrice)
            {
                string key = game.Key;
                if (gameDlc.ContainsKey(key))
                {
                    dlcFinalPrice[key] = game.Value - (game.Value * 0.5);
                }
                else
                {
                    gameFinalPrice[key] = game.Value - (game.Value * 0.2);
                }
            }

            foreach (var game in dlcFinalPrice.OrderBy(x => x.Value).ThenBy(c => c.Key))
            {
                string key = game.Key;
                string dlc = gameDlc[key];
                Console.WriteLine($"{game.Key} - {dlc} - {game.Value:F2}");
            }
            foreach (var game in gameFinalPrice.OrderByDescending(x => x.Value).ThenBy(c => c.Key))
            {
                Console.WriteLine($"{game.Key} - {game.Value:F2}");
            }

        }
    }
}
