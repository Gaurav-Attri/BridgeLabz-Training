/*
 * Problem - Codeforces 158A Next Round
 * */
using System;

class NextRound
{
    static void Main(string[] args)
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int k = int.Parse(firstLine[1]);

        string[] scoresInput = Console.ReadLine().Split();
        int[] v = new int[n];

        for (int i = 0; i < n; i++)
        {
            v[i] = int.Parse(scoresInput[i]);
        }

        int cnt = 0;
        int threshold = v[k - 1];

        for (int i = 0; i < n; i++)
        {
            if (v[i] > 0 && v[i] >= threshold)
                cnt++;
        }

        Console.WriteLine(cnt);
    }
}

