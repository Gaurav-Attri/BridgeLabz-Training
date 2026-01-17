/*
 * Problem - Codeforces 59A Word
 * */
using System;

class Word
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();

        int uc = 0, lc = 0;

        foreach (char c in str)
        {
            if (c >= 'a' && c <= 'z') lc++;
            else uc++;
        }

        char[] arr = str.ToCharArray();

        if (uc > lc)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 'a' && arr[i] <= 'z')
                    arr[i] = (char)(arr[i] - 32);
            }
        }
        else
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 'A' && arr[i] <= 'Z')
                    arr[i] = (char)(arr[i] + 32);
            }
        }

        Console.WriteLine(new string(arr));
    }
}

