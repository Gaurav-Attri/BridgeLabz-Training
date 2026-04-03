using System;

class DateArithmetic{
    static void Main(string[] args){
        Console.Write("Enter a date (yyyy-mm-dd): ");
        string inputDate = Console.ReadLine();

        DateTime givenDate = DateTime.Parse(inputDate);

        // Performing date operations
        PerformDateOperations(givenDate);
    }

    static void PerformDateOperations(DateTime date){
        Console.WriteLine("\nOriginal Date: " + date.ToShortDateString());

        // Adding 7 days
        DateTime after7Days = date.AddDays(7);
        Console.WriteLine("After adding 7 days: " + after7Days.ToShortDateString());

        // Adding 1 month
        DateTime after1Month = after7Days.AddMonths(1);
        Console.WriteLine("After adding 1 month: " + after1Month.ToShortDateString());

        // Adding 2 years
        DateTime after2Years = after1Month.AddYears(2);
        Console.WriteLine("After adding 2 years: " + after2Years.ToShortDateString());

        // Subtracting 3 weeks (3 weeks = 21 days)
        DateTime finalDate = after2Years.AddDays(-21);
        Console.WriteLine("After subtracting 3 weeks: " + finalDate.ToShortDateString());
    }
}

