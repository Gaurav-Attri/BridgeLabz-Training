/*
 * Problem - Codeforces 50A Domino Piling
 * */
using System;

class DominoPiling
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int m = int.Parse(input[0]);
        int n = int.Parse(input[1]);

        Console.WriteLine((m * n) / 2);
    }
}

