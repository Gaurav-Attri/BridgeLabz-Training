using System;

public class SimpleInterest
{
    public static void Main(string[] args)
    {
        Console.Write("Enter principal: ");
        int principal = int.Parse(Console.ReadLine());

        Console.Write("Enter rate: ");
        int rate = int.Parse(Console.ReadLine());

        Console.Write("Enter time: ");
        int time = int.Parse(Console.ReadLine());

        int si = (principal * rate * time) / 100;
        Console.WriteLine("Simple interest is: " + si);
    }
}
