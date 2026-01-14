/*
 * Problem - Codeforces 4A Watermelon
 * */
using System;

class Watermelon
{
    static void Main(string[] args)
    {
        int w = int.Parse(Console.ReadLine());

        if (w % 2 == 0 && w != 2)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}

