using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P02.SongEncryption
{
    class SongEncryption
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string pattern = @"^(?<band>[A-Z][a-z ']+):(?<song>[A-Z ]+)";
            Regex valid = new Regex(pattern);

            while ((input = Console.ReadLine()) != "end")
            {
                if (valid.IsMatch(input))
                {
                    StringBuilder result = new StringBuilder();
                    Match validMatch = valid.Match(input);
                    string band = validMatch.Groups["band"].Value;
                    string song = validMatch.Groups["song"].Value;

                    int key = band.Length;

                    if ((char)(band[0] + key) > 'Z')
                    {
                        char firstEncrypted = (char)((band[0] + key) - 26);
                        result.Append(firstEncrypted);
                    }
                    else
                    {
                        char firstEncrypted = (char)(band[0] + key);
                        result.Append(firstEncrypted);
                    }
                    foreach (var letter in band.Skip(1))
                    {
                        if (!(letter == ' ') && !(letter == '\''))
                        {


                            if ((char)(letter + key) > 'z')
                            {
                                char firstEncrypted = (char)((letter + key) - 26);
                                result.Append(firstEncrypted);
                            }
                            else
                            {
                                char firstEncrypted = (char)(letter + key);
                                result.Append(firstEncrypted);
                            }
                        }
                        else
                        {
                            result.Append(letter);
                        }
                    }

                    result.Append("@");

                    foreach (var letter in song)
                    {
                        if (!(letter == ' ') && !(letter == '\''))
                        {



                            if ((char)(letter + key) > 'Z')
                            {
                                char firstEncrypted = (char)((letter + key) - 26);
                                result.Append(firstEncrypted);
                            }
                            else
                            {
                                char firstEncrypted = (char)(letter + key);
                                result.Append(firstEncrypted);
                            }
                        }
                        else
                        {
                            result.Append(letter);
                        }
                        

                    }

                    Console.WriteLine($"Successful encryption: {result}");

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
