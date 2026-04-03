/*
 * Problem - Codeforces 61A Ultra Fast Mathematician
 * */
using System;

class UltraFastMathematician
{
    static void Main(string[] args)
    {
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();

        char[] ans = new char[num1.Length];

        for (int i = 0; i < num1.Length; i++)
        {
            ans[i] = (num1[i] != num2[i]) ? '1' : '0';
        }

        Console.WriteLine(new string(ans));
    }
}

