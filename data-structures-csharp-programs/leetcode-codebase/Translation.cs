/*
 * Problem - Codeforces 41A Translation
 * */
using System;

class Translation
{
    static void Main(string[] args)
    {
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();

        if (str1.Length != str2.Length)
        {
            Console.WriteLine("NO");
            return;
        }

        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[str1.Length - i - 1])
            {
                Console.WriteLine("NO");
                return;
            }
        }

        Console.WriteLine("YES");
    }
}

