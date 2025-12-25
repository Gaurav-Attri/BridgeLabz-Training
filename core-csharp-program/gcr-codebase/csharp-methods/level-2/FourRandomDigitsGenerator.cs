using System;

class FourRandomDigitsGenerator{
    static void Main(string[] args){
        int[] randomNumbers = Generate4DigitRandomArray();

        Console.WriteLine("Five four digits random numbers are: ");
        for(int i = 0; i < 5; i++){
            Console.Write(randomNumbers[i] + " ");
        }
	Console.WriteLine();

        double[] result = FindAverageMinMax(randomNumbers);

	Console.WriteLine("Results:");
        Console.WriteLine("Average = " + result[0]);
        Console.WriteLine("Minimum = " + result[1]);
        Console.WriteLine("Maximum = " + result[2]);
    }

    public static int[] Generate4DigitRandomArray(){
        int[] randomNumbers = new int[5];
        Random rand = new Random();

        for (int i = 0; i < 5; i++){
            randomNumbers[i] = rand.Next(1000, 10000); // 4-digit number
        }

        return randomNumbers;
    }

    public static double[] FindAverageMinMax(int[] randomNumbers){
        int min = randomNumbers[0];
        int max = randomNumbers[0];
        int sum = 0;

        for(int i = 0; i < 5; i++){
            sum += randomNumbers[i];
            min = Math.Min(min, randomNumbers[i]);
            max = Math.Max(max, randomNumbers[i]);
        }

        double average = (double)sum / randomNumbers.Length;

        return new double[] { average, min, max };
    }
}

