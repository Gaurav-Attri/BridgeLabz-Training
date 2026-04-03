using System;

public class CelToFah
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the temperature in Celsius: ");
        double cel = Convert.ToDouble(Console.ReadLine());
        double fah = (cel * 9.0 / 5.0) + 32;
        Console.WriteLine("Temperature in Fahrenheit: " + fah);
    }
}
