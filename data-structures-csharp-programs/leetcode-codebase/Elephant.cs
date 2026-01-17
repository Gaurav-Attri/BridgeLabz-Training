/*
 * Problem - Codeforces 617A Elephant
 * */
using System;

class Elephant
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int cnt = 0;

        for (int i = 5; i >= 1; i--)
        {
            cnt += x / i;
            x %= i;
        }

        Console.WriteLine(cnt);
    }
}

