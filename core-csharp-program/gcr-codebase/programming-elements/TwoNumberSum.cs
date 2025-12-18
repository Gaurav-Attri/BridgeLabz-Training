using System;

public class TwoNumberSum
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Sum of the two numbers is: " + (n1 + n2));
    }
}
