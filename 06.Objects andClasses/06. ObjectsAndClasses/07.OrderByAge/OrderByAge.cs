using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class OrderByAge
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            List<Person> peopleList = new List<Person>();
            while (input[0] != "End")
            {
                Person next = new Person(input[0], input[1], int.Parse(input[2]));
                peopleList.Add(next);
                input = Console.ReadLine().Split().ToList();
            }

            peopleList = peopleList.OrderBy(x => x.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, peopleList));
        }
    }

    public class Person
    {
        public string Name;
        public string Id;
        public int Age;

        public Person()
        {
        }
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
}
