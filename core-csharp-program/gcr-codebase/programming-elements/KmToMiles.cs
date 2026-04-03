using System;

public class KmToMiles
{
    public static void Main(string[] args)
    {
        Console.Write("Enter distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());
        double miles = km * 0.621371;
        Console.WriteLine("Distance in miles: " + miles);
    }
}
