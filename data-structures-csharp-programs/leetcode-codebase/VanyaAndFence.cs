/*
 * Problem - Codeforces 677A Vanya and Fence
 * */
using System;

class VanyaAndFence
{
    static void Main(string[] args)
    {
        string[] first = Console.ReadLine().Split();
        int n = int.Parse(first[0]);
        int h = int.Parse(first[1]);

        string[] parts = Console.ReadLine().Split();
        int ans = 0;

        foreach (string s in parts)
        {
            int e = int.Parse(s);
            ans += (e > h) ? 2 : 1;
        }

        Console.WriteLine(ans);
    }
}

