﻿using System;

namespace _03.Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)n / p);

            Console.WriteLine(courses);
           
        }
    }
}
