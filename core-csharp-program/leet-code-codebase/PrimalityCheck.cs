using System;

public class PrimalityCheck
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        if (IsPrime(n))
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not Prime");
        }
    }

    public static bool IsPrime(int n)
    {
        if (n == 1) return false;
        if (n == 2) return true;

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
}
