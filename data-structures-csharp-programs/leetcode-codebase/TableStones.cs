/*
 * Problem - Codeforces 266A Stones on the Table
 * */
using System;

class TableStones
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        int ans = 0;
        char prevChar = s[0];

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == prevChar)
            {
                ans++;
            }
            else
            {
                prevChar = s[i];
            }
        }

        Console.WriteLine(ans);
    }
}

