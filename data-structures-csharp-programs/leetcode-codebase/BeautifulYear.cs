/*
 * Problem - Codeforces 271A Beautiful Year
 * */
using System;

class BeautifulYear
{
    static bool IsBeautiful(int n)
    {
        int[] digits = new int[10];

        while (n != 0)
        {
            digits[n % 10]++;
            n /= 10;
        }

        for (int i = 0; i < 10; i++)
        {
            if (digits[i] > 1)
                return false;
        }

        return true;
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        do
        {
            n++;
        }
        while (!IsBeautiful(n));

        Console.WriteLine(n);
    }
}

