using System;
class NumberCheckerV2{
    static void Main(string[] args){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int digitCount = CountDigits(number);
        int[] digits = StoreDigits(number, digitCount);

        Console.WriteLine("Total Digits: " + digitCount);

        int sum = FindSumOfDigits(digits);
        Console.WriteLine("Sum of Digits: " + sum);

        int squareSum = FindSumOfSquares(digits);
        Console.WriteLine("Sum of Squares of Digits: " + squareSum);

        if (IsHarshad(number, digits)){
            Console.WriteLine("It is a Harshad Number");
        }
        else{
            Console.WriteLine("It is NOT a Harshad Number");
        }

        int[,] frequency = FindDigitFrequency(digits);

        Console.WriteLine("Digit Frequency:");
        Console.WriteLine("Digit\tCount");

        for (int i = 0; i < frequency.GetLength(0); i++){
            if (frequency[i, 1] > 0){
                Console.WriteLine(frequency[i, 0] + "\t" + frequency[i, 1]);
            }
        }
    }

    static int CountDigits(int num){
        int count = 0;
        while (num > 0){
            count++;
            num = num / 10;
        }
        return count;
    }

    static int[] StoreDigits(int num, int size){
        int[] digits = new int[size];
        for (int i = size - 1; i >= 0; i--){
            digits[i] = num % 10;
            num = num / 10;
        }
        return digits;
    }

    static int FindSumOfDigits(int[] digits){
        int sum = 0;
        for (int i = 0; i < digits.Length; i++){
            sum += digits[i];
        }
        return sum;
    }

    static int FindSumOfSquares(int[] digits){
        int sum = 0;
        for (int i = 0; i < digits.Length; i++){
            sum += (int)Math.Pow(digits[i], 2);
        }
        return sum;
    }

    static bool IsHarshad(int number, int[] digits){
        int sum = FindSumOfDigits(digits);
        if (sum == 0){
            return false;
        }
        return number % sum == 0;
    }

    static int[,] FindDigitFrequency(int[] digits){
        int[,] freq = new int[10, 2];
        for (int i = 0; i < 10; i++){
            freq[i, 0] = i;
            freq[i, 1] = 0;
        }

        for (int i = 0; i < digits.Length; i++){
            int digit = digits[i];
            freq[digit, 1]++;
        }
        return freq;
    }
}
