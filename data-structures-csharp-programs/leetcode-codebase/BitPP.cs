/*
 * Problem - Codeforces 282A Bit++
 * */
using System;

class BitPP
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int x = 0;

        while (n-- > 0)
        {
            string inst = Console.ReadLine();

            if (inst[1] == '+')
                x++;
            else
                x--;
        }

        Console.WriteLine(x);
    }
}

