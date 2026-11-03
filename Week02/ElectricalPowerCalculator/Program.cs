
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== ELECTRICAL POWER CALCULATOR =====");

        Console.Write("How many devices? ");
        int numberOfDevices = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= numberOfDevices; i++)
        {
            Console.WriteLine("\nDevice " + i);

            Console.Write("Enter voltage (V): ");
            double voltage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter current (A): ");
            double current = Convert.ToDouble(Console.ReadLine());

            double power = voltage * current;

            Console.WriteLine("Power: " + power + " Watts");

            if (power < 100)
            {
                Console.WriteLine("Classification: Low");
            }
            else if (power <= 500)
            {
                Console.WriteLine("Classification: Medium");
            }
            else
            {
                Console.WriteLine("Classification: High");
            }
        }

        Console.WriteLine("\nCalculation completed!");
    }
}
