/*
 * Problem - Codeforces 1030A In search of an easy problem
 * */
using System;

class InSearchOfAnEasyProblem
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()!);
        int sum = 0;

        string[] parts = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < n; i++)
        {
            sum += int.Parse(parts[i]);
        }

        Console.WriteLine(sum == 0 ? "EASY" : "HARD");
    }
}

