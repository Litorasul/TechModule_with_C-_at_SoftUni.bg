using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P02.ActivationKeys
{
    class ActivationKeys
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("&").ToArray();
            string pattern = @"^[A-z\d]+$";
            Regex valid = new Regex(pattern);
            List<StringBuilder> result = new List<StringBuilder>();

            for (int i = 0; i < input.Length; i++)
            {
                if (valid.IsMatch(input[i]))
                {
                    StringBuilder readyKey = new StringBuilder();
                    if (input[i].Length == 16)
                    {
                        char currentChar;
                        foreach (var letter in input[i])
                        {
                            int i = 1;
                            if (char.IsLetter(letter))
                            {
                                currentChar = char.ToUpper(letter); 
                            }
                            else if (char.IsDigit(letter))
                            {
                                currentChar = (char)('9' - letter);
                            }
                           
                        }
                    }
                    else if (input[i].Length==25)
                    {

                    }
                }
            }
        }
    }
}
