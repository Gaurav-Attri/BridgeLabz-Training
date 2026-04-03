/*
 * Problem - Codeforces 705A Hulk
 * */
using System;

class Hulk
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i % 2 == 1 ? "I hate " : "I love ");
            Console.Write(i == n ? "it" : "that ");
        }
    }
}

