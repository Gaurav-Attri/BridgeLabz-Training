using System;
using System.Collections.Generic;

public class StringCharFreq
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();

        Dictionary<char, int> map = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (map.ContainsKey(c))
                map[c]++;
            else
                map[c] = 1;
        }

        foreach (KeyValuePair<char, int> entry in map)
        {
            Console.WriteLine(entry.Key + " " + entry.Value);
        }
    }
}
