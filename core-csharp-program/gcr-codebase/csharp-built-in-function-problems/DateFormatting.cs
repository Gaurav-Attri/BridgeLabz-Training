using System;
class DateFormatting{
    static void Main(string[] args){
        // Getting current date
        DateTime currentDate = DateTime.Now;

        // Displaying date in different formats
        DisplayFormattedDates(currentDate);
    }

    static void DisplayFormattedDates(DateTime date){
        Console.WriteLine("Current Date in Different Formats:\n");

        // Format: dd/MM/yyyy
        Console.WriteLine("dd/MM/yyyy : " + date.ToString("dd/MM/yyyy"));

        // Format: yyyy-MM-dd
        Console.WriteLine("yyyy-MM-dd : " + date.ToString("yyyy-MM-dd"));

        // Format: EEE, MMM dd, yyyy
        Console.WriteLine("EEE, MMM dd, yyyy : " + date.ToString("ddd, MMM dd, yyyy"));
    }
}

