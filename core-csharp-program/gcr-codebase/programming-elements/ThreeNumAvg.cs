using System;

public class ThreeNumAvg
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the numbers: ");
        int[] arr = new int[3];

        for (int i = 0; i < 3; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        double average = (arr[0] + arr[1] + arr[2]) / 3.0;
        Console.WriteLine("Average: " + average);
    }
}
