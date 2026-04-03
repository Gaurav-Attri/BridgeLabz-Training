/*
 * Problem - Codeforces 791A Bear and Big Brother
 * */
using System;

class BearAndBigBrothers
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        int cnt = 0;

        while (a <= b)
        {
            a *= 3;
            b *= 2;
            cnt++;
        }

        Console.WriteLine(cnt);
    }
}

