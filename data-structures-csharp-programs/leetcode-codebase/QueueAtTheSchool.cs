/*
 * Problem - Codeforces 266B Queue at the School
 * */
using System;

class QueueAtTheSchool
{
    static void Main(string[] args)
    {
        var firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int t = int.Parse(firstLine[1]);

        char[] s = Console.ReadLine().ToCharArray();

        while (t-- > 0)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (s[i] == 'B' && s[i + 1] == 'G')
                {
                    char tmp = s[i];
                    s[i] = s[i + 1];
                    s[i + 1] = tmp;
                    i++;
                }
            }
        }

        Console.WriteLine(new string(s));
    }
}

