/*
 * Problem - Codeforces 546A Soldier and Bananas
 * */
using System;

class SoldiersBananas
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        int k = int.Parse(input[0]);
        int n = int.Parse(input[1]);
        int w = int.Parse(input[2]);

        int total = k * (w * (w + 1) / 2);
        int ans = Math.Max(0, total - n);

        Console.WriteLine(ans);
    }
}

