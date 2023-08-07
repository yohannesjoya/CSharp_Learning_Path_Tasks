using System;
using System.Collections.Generic;

namespace StudentGradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Grade Calculator!");
            Console.Write("Please enter your name: ");
            string studentName = Console.ReadLine();

            Console.Write("Please enter the number of subjects you have taken: ");
            int numSubjects = int.Parse(Console.ReadLine());

            Dictionary<string, double> grades = new Dictionary<string, double>();

            for (int i = 0; i < numSubjects; i++)
            {
                Console.Write("Enter the subject name: ");
                string subjectName = Console.ReadLine();

                Console.Write("Enter the grade obtained (numeric value): ");
                double grade = double.Parse(Console.ReadLine());

                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Invalid grade value. Please enter a value between 0 and 100.");
                    i--;
                    continue;
                }

                grades.Add(subjectName, grade);
            }

            Console.WriteLine("\nStudent Name: " + studentName);
            Console.WriteLine("Subject Grades:");
            foreach (KeyValuePair<string, double> grade in grades)
            {
                Console.WriteLine(grade.Key + ": " + grade.Value);
            }
            Console.WriteLine("Average Grade: " + CalculateAverageGrade(grades));
        }

        static double CalculateAverageGrade(Dictionary<string, double> grades)
        {
            double total = 0;
            foreach (double grade in grades.Values)
            {
                total += grade;
            }
            return total / grades.Count;
        }
    }
}
