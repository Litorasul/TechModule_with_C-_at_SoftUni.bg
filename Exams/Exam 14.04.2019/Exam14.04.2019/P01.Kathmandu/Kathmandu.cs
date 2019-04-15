using System;
using System.Text;
using System.Text.RegularExpressions;

namespace P01.Kathmandu
{
    class Kathmandu
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string pattern = @"^(?<name>[[A-z\d!@#$?]+)=(?<lenght>[0-9]+)<<(?<hash>[\w\W]+)$";
            Regex valid = new Regex(pattern);
           

            while ((input = Console.ReadLine()) != "Last note")
            {
                Match validMatch = valid.Match(input);
                if (valid.IsMatch(input))
                {
                    string name = validMatch.Groups["name"].Value;
                    int lenght = int.Parse(validMatch.Groups["lenght"].Value);
                    string hash = validMatch.Groups["hash"].Value;

                    if (hash.Length == lenght)
                    {
                        StringBuilder propperName = new StringBuilder();
                        foreach (var letter in name)
                        {
                            if (char.IsLetterOrDigit(letter))
                            {
                                propperName.Append(letter);
                            }
                        }

                        Console.WriteLine($"Coordinates found! {propperName} -> {hash}");
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
