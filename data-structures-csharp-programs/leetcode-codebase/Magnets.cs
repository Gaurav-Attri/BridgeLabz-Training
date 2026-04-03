/*
 * Problem - Codeforces 344A Magnets
 * */
using System;

class Magnets
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int ans = 1;

        string prev = "pp";
        string cur;

        for (int i = 0; i < n; i++)
        {
            cur = Console.ReadLine();
            if (cur[0] == prev[1]) ans++;
            prev = cur;
        }

        Console.WriteLine(ans);
    }
}

