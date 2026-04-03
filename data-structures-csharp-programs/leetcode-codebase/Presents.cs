/*
 * Problem - Codeforces 136A Presents
 * */
using System;

class Presents
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[101];

        string[] inputs = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            int f = int.Parse(inputs[i]);
            arr[f - 1] = i + 1;
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

