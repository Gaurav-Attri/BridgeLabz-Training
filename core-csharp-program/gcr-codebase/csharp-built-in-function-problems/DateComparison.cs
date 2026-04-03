using System;
class DateComparison{
    static void Main(string[] args){
        // Taking first date input
        Console.Write("Enter first date (yyyy-mm-dd): ");
        string firstInput = Console.ReadLine();
        DateTime firstDate = DateTime.Parse(firstInput);

        // Taking second date input
        Console.Write("Enter second date (yyyy-mm-dd): ");
        string secondInput = Console.ReadLine();
        DateTime secondDate = DateTime.Parse(secondInput);

        // Comparing dates
        CompareDates(firstDate, secondDate);
    }

    static void CompareDates(DateTime date1, DateTime date2){
        Console.WriteLine("\nComparison Result:");

        // Using CompareTo method
        int result = date1.CompareTo(date2);

        if (result < 0)
        {
            Console.WriteLine("First date is BEFORE the second date.");
        }
        else if (result > 0)
        {
            Console.WriteLine("First date is AFTER the second date.");
        }
        else
        {
            Console.WriteLine("Both dates are the SAME.");
        }
    }
}

