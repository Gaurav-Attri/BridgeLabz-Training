/*
 * Problem - Codeforces 236A Boy or Girl
 * */
using System;

class BoyOrGirl
{
    static void Main(string[] args)
    {
        int[] freq = new int[26];
        int charCount = 0;

        string str = Console.ReadLine();

        for (int i = 0; i < str.Length; i++)
        {
            freq[str[i] - 'a']++;
        }

        for (int i = 0; i < 26; i++)
        {
            if (freq[i] > 0)
                charCount++;
        }

        Console.WriteLine(charCount % 2 != 0 ? "IGNORE HIM!" : "CHAT WITH HER!");
    }
}

