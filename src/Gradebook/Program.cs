using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Class Gradebook");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            var result = 0.0;
            var highestGrade = double.MinValue;
            var lowestGrade = double.MaxValue;

            foreach(var number in grades)
            {
                lowestGrade = Math.Min(number, lowestGrade);
                highestGrade = Math.Max(number, highestGrade);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The lowest grade is {lowestGrade}");
            Console.WriteLine($"The highest grade is {highestGrade}");
            Console.WriteLine($"The average grade is {result:N1}");
        }
    }
}
