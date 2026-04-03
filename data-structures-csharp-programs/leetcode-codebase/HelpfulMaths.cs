/*
 * Problem - Codeforces 339A Helpful Maths
 * */
using System;
using System.Text;

class HelpfulMaths
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();

        StringBuilder operands = new StringBuilder();

        foreach (char c in str)
        {
            if (c != '+')
                operands.Append(c);
        }

        char[] arr = operands.ToString().ToCharArray();
        Array.Sort(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i != arr.Length - 1)
                Console.Write("+");
        }
    }
}

