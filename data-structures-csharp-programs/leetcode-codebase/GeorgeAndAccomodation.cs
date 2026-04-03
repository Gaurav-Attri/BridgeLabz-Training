/*
 * Problme - Codeforces 467A George and Accomodation
 * */
using System;

class GeorgeAndAccomodation
{
    static void Main(string[] arsg)
    {
        int n = int.Parse(Console.ReadLine());
        int ans = 0;

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split();
            int size = int.Parse(parts[0]);
            int cap = int.Parse(parts[1]);

            if (cap - size >= 2)
                ans++;
        }

        Console.WriteLine(ans);
    }
}

