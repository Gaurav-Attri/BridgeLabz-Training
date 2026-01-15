/*
 * Problem - Codeforces 263A Beautiful Matrix
 * */
using System;

class BeautifulMatrix
{
    static void Main(string[] args)
    {
        int[,] mat = new int[5, 5];
        int onesRow = 0, onesCol = 0;

        for (int i = 0; i < 5; i++)
        {
            string[] input = Console.ReadLine().Split();

            for (int j = 0; j < 5; j++)
            {
                mat[i, j] = int.Parse(input[j]);

                if (mat[i, j] == 1)
                {
                    onesRow = i;
                    onesCol = j;
                }
            }
        }

        int result = Math.Abs(2 - onesRow) + Math.Abs(2 - onesCol);
        Console.WriteLine(result);
    }
}

