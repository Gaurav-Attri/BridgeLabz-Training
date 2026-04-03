/*
 * Problem - Codeforces 977A Wrong Subtraction
 * */
using System;

class WrongSubtraction
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);

        while (k-- > 0)
        {
            if (n % 10 != 0)
                n--;
            else
                n /= 10;
        }

        Console.WriteLine(n);
    }
}

