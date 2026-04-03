/*
 * Problem - Codeforces 112A Petya and Strings
 * */
using System;

class PetyaAndStrings
{
    static void Main(string[] args)
    {
        int res = 0;

        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();

        for (int i = 0; i < str1.Length; i++)
        {
            char c1 = str1[i] >= 'a' ? str1[i] : (char)(str1[i] + 32);
            char c2 = str2[i] >= 'a' ? str2[i] : (char)(str2[i] + 32);

            if (c1 < c2)
            {
                res = -1;
                break;
            }
            else if (c1 > c2)
            {
                res = 1;
                break;
            }
        }

        Console.WriteLine(res);
    }
}

