using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Deciphering
{
    class Deciphering
    {
        static void Main(string[] args)
        {
            string encryptedString = Console.ReadLine();
            string pattern = @"^[d-z\{\}\|\#]*$";
            Regex validText = new Regex(pattern);
            Match isValid = validText.Match(encryptedString);
            string[] toReplace = Console.ReadLine().Split().ToArray();
            string old = toReplace[0];
            string replacer = toReplace[1];
            StringBuilder decryptedString = new StringBuilder();

            if (isValid.Success)
            {
                foreach (char letter in encryptedString.ToCharArray())
                { 
                    char curentChar = (char)(letter - 3);
                    decryptedString.Append(curentChar);
                }

                decryptedString.Replace(old, replacer);

                Console.WriteLine(decryptedString);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");

            }
        }
    }
}
