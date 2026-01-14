/*
 * Problem - Codeforces 231A Team
 * */

using System;

class Team
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int cnt = 0;

        while (n-- > 0)
        {
            string[] parts = Console.ReadLine().Split();
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                sum += int.Parse(parts[i]);
            }

            if (sum >= 2) cnt++;
        }

        Console.WriteLine(cnt);
    }
}

