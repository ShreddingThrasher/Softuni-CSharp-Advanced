using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> studentRecords = new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string studentName = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!studentRecords.ContainsKey(studentName))
                {
                    studentRecords.Add(studentName, new List<decimal>());
                }

                studentRecords[studentName].Add(grade);
            }

            foreach (var student in studentRecords)
            {
                decimal averageGrade = studentRecords[student.Key].Average();
                string grades = string.Join(' ', studentRecords[student.Key].Select(x => $"{x:F2}"));
                Console.WriteLine($"{student.Key} -> {grades} (avg: {averageGrade:F2})");
            }
        }
    }
}
