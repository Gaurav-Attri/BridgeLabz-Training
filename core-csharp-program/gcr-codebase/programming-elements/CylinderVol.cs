using System;

public class CylinderVol
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double volume = 3.14 * radius * radius * height;
        Console.WriteLine("Volume is: " + volume);
    }
}
