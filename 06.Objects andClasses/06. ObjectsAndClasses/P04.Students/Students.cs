using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var studentsList = new List<Students>();
            for (int i = 0; i < count; i++)
            {
                List<string> studentsInput = Console.ReadLine().Split().ToList();
                var student = new Students(studentsInput[0],
                    studentsInput[1],
                    double.Parse(studentsInput[2]));

                studentsList.Add(student);
            }

            studentsList = studentsList.OrderByDescending(X => X.Grade).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, studentsList));

        }
    }

    public class Students
    {
        public string FirstName;
        public string FamilyName;
        public double Grade;

        public Students()
        {
        }

        public Students(string firstName, string familyName, double grade)
        {
            FirstName = firstName;
            FamilyName = familyName;
            Grade = grade;
        }
        public override string ToString()
        {
            return $"{FirstName} {FamilyName}: {Grade:F2}";
        }
    }
}
