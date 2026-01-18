/*
 * Problem - Codeforces 116A Tram
 * */
using System;

class Tram
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int total = 0;
        int maxi = 0;

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split();
            int ex = int.Parse(parts[0]);
            int en = int.Parse(parts[1]);

            total = total - ex + en;
            if (total > maxi)
                maxi = total;
        }

        Console.WriteLine(maxi);
    }
}

