using System;

public class CircleArea
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the radius of the circle: ");
        float rad = float.Parse(Console.ReadLine());
        float area = 3.14f * rad * rad;
        Console.WriteLine("Area of the circle is: " + area);
    }
}
