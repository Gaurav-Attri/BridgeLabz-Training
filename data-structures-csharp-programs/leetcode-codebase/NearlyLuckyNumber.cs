/*
 * Problem - Codeforces 100A Nearly lucky number
 * */
using System;

class NearlyLuckyNumber
{
    static void Main(string[] args)
    {
        long n, temp;
        int ldc = 0;
        bool nl = true;

        n = long.Parse(Console.ReadLine());
        temp = n;

        while (temp != 0)
        {
            if (temp % 10 == 4 || temp % 10 == 7) ldc++;
            temp /= 10;
        }

        temp = ldc;

        while (temp != 0)
        {
            if (temp % 10 != 4 && temp % 10 != 7)
            {
                nl = false;
                break;
            }
            temp /= 10;
        }

        Console.WriteLine(ldc != 0 && nl ? "YES" : "NO");
    }
}

