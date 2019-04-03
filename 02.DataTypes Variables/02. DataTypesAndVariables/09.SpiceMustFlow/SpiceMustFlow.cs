using System;

namespace _09.SpiceMustFlow
{
    class SpiceMustFlow
    {
        static void Main(string[] args)
        {
            int spiceYield = int.Parse(Console.ReadLine());

            long days = 0;
            long spiceExtracted = 0;
            int yieldLeft = spiceYield;

            while (yieldLeft >= 100)
            {
                spiceExtracted += yieldLeft;
                days++;
                spiceExtracted -= 26;
                yieldLeft -= 10;
            }

            if (days != 0)
            {
                spiceExtracted -= 26;
            }
            

            Console.WriteLine(days);
            Console.WriteLine(spiceExtracted);


        }
    }
}
