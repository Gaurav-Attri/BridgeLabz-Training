/*
 * Problem - Codeforces 486A Calculating Function 
 * */
using System;

class CalculatingFunction
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());

        long oc = (n % 2 == 0) ? n / 2 : (n + 1) / 2;
        long ec = (n % 2 == 0) ? n / 2 : (n - 1) / 2;

        long ans = ec * ec + ec - oc * oc;

        Console.WriteLine(ans);
    }
}

