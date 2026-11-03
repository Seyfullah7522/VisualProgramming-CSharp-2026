
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== STUDENT GRADE ANALYZER =====");

        Console.Write("How many students? ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        double total = 0;

        for (int i = 1; i <= numberOfStudents; i++)
        {
            Console.Write("Enter grade for student " + i + ": ");
            double grade = Convert.ToDouble(Console.ReadLine());

            total += grade;
        }

        double average = total / numberOfStudents;

        Console.WriteLine("\n===== RESULTS =====");
        Console.WriteLine("Total Grades: " + total);
        Console.WriteLine("Average Grade: " + average);
    }
}
