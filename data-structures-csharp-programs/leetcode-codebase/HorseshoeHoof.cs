/*
 * Problem - Codeforces 228A Is your horseshoe on the other hoof
 * */
using System;
using System.Collections.Generic;

class HorseshoeHoof
{
    static void Main(string[] args)
    {
        HashSet<int> set = new HashSet<int>();
        string[] input = Console.ReadLine().Split();

        for (int i = 0; i < 4; i++)
        {
            set.Add(int.Parse(input[i]));
        }

        Console.WriteLine(4 - set.Count);
    }
}

