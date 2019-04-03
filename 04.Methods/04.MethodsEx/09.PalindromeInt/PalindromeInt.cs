using System;
using System.Linq;

namespace _09.PalindromeInt
{
    class PalindromeInt
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool check = false;

            while (input != "END")
            {
                check = PalindromeCheck(input);
                if (check == true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }
            
        }

        private static bool PalindromeCheck(string input)
        {

            string rev = new string(input.Reverse().ToArray());
            if (input == rev )
            {
                return true;
            }

            return false;


        }
    }
}
