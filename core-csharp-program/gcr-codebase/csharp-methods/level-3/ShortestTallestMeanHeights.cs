using System;

class ShortestTallestMeanHeights{
    static void Main(string[] args){
        int[] playersHeights = new int[11];
        Random rand = new Random();

        // Generating random heights for the 11 players
        for (int i = 0; i < 11; i++)
        {
            playersHeights[i] = rand.Next(150, 251); // 150 to 250 cm
        }

        Console.WriteLine("Player Heights (in cm):");
        for(int i = 0; i < 11; i++){
            Console.Write(playersHeights[i] + " ");
        }
	Console.WriteLine();

        int total = FindSum(playersHeights);
        double mean = FindMean(playersHeights);
        int shortest = FindShortest(playersHeights);
        int tallest = FindTallest(playersHeights);

        Console.WriteLine("Total Height = " + total);
        Console.WriteLine("Mean Height = " + mean);
        Console.WriteLine("Shortest Height = " + shortest);
        Console.WriteLine("Tallest Height = " + tallest);
    }

    static int FindSum(int[] playersHeights){
        int sum = 0;
        for(int i = 0; i < 11; i++){
            sum += playersHeights[i];
        }
        return sum;
    }

    static double FindMean(int[] playersHeights){
        int sum = FindSum(playersHeights);
        return (double)(sum) / playersHeights.Length;
    }

    static int FindShortest(int[] playersHeights){
        int min = playersHeights[0];
        for(int i = 0; i < 11; i++){
            if (playersHeights[i] < min){
                min = playersHeights[i];
	    }
        }
        return min;
    }

    static int FindTallest(int[] playersHeights){
        int max = playersHeights[0];
        for(int i = 0; i < 11; i++){
            if (playersHeights[i] > max){
                max = playersHeights[i];
	    }
        }
        return max;
    }
}

