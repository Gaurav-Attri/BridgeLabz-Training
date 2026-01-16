/*
 * Problem - Codeforces 281A Word Capitalization
 * */
using System;

class WordCapitalization
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();

        if (!string.IsNullOrEmpty(str) && str[0] >= 'a' && str[0] <= 'z')
        {
            char[] arr = str.ToCharArray();
            arr[0] = (char)(arr[0] - 32);
            str = new string(arr);
        }

        Console.Write(str);
    }
}

