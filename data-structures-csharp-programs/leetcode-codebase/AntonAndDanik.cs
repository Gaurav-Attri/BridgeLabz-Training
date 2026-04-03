/*
 * Problem - Codeforces 734A Anton and Danik
 * */
using System;

class AntonAndDanik
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        string str = input[1];

        int ac = 0, dc = 0;

        foreach (char c in str)
        {
            if (c == 'A') ac++;
            else dc++;
        }

        Console.WriteLine(ac > dc ? "Anton" : (dc > ac ? "Danik" : "Friendship"));
    }
}

