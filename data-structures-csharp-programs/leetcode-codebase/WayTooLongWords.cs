/*
 * Problem - Codeforces 71A Way Too Long Words
 * */
using System;

class WayTooLongWords
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        while (n-- > 0)
        {
            string s = Console.ReadLine();

            if (s.Length > 10)
            {
                Console.WriteLine($"{s[0]}{s.Length - 2}{s[s.Length - 1]}");
            }
            else
            {
                Console.WriteLine(s);
            }
        }
    }
}

