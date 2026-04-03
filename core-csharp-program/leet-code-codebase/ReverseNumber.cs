using System;

public class ReverseNumber
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Reversed: " + Reverse(num));
    }

    public static int Reverse(int num)
    {
        int rev = 0;
        while (num != 0)
        {
            int digit = num % 10;
            rev = rev * 10 + digit;
            num = num / 10;
        }
        return rev;
    }
}
