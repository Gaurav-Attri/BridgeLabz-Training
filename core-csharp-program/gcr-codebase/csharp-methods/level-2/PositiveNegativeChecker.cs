using System;

class PositiveNegativeChecker{
     static void Main(string[] args){
        int[] numbers = new int[5];

        Console.WriteLine("Enter 5 numbers: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Processing each of the numbers entered by the user
        for (int i = 0; i < 5; i++)
        {
            if (CheckPositive(numbers[i]))
            {
                Console.Write(numbers[i] + " is Positive and ");

                if (CheckEven(numbers[i]))
                    Console.WriteLine("Even");
                else
                    Console.WriteLine("Odd");
            }
            else
            {
                Console.WriteLine(numbers[i] + " is Negative");
            }
        }
	Console.WriteLine();

        // Comparing first and last element
        int result = CompareNumbers(numbers[0], numbers[4]);

        if (result == 1){
            Console.WriteLine("First number is greater than the last number");
	}
        else if (result == 0){
            Console.WriteLine("First and last numbers are equal");
	}
        else{
            Console.WriteLine("First number is less than the last number");
	}
    }

    static bool CheckPositive(int num){
        return num >= 0;
    }


    static bool CheckEven(int num){
        return num%2 == 0;
    }

    static int CompareNumbers(int a, int b){
        if (a > b)
            return 1;
        else if (a == b)
            return 0;
        else
            return -1;
    }
}
