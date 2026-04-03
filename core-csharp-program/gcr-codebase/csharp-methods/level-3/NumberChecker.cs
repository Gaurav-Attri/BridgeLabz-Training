using System;
class NumberChecker{
    static void Main(string[] args){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int digitCount = CountDigits(number);
        int[] digits = StoreDigits(number, digitCount);

        Console.WriteLine("Total Digits: " + digitCount);

        if (IsDuckNumber(digits)){
            Console.WriteLine("It is a Duck Number");
        }
        else{
            Console.WriteLine("It is NOT a Duck Number");
        }

        if (IsArmstrong(number, digits)){
            Console.WriteLine("It is an Armstrong Number");
        }
        else{
            Console.WriteLine("It is NOT an Armstrong Number");
        }

        int[] largest = FindLargestAndSecondLargest(digits);
        Console.WriteLine("Largest Digit: " + largest[0]);
        Console.WriteLine("Second Largest Digit: " + largest[1]);

        int[] smallest = FindSmallestAndSecondSmallest(digits);
        Console.WriteLine("Smallest Digit: " + smallest[0]);
        Console.WriteLine("Second Smallest Digit: " + smallest[1]);
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

    static bool IsDuckNumber(int[] digits){
        for (int i = 0; i < digits.Length; i++){
            if (digits[i] != 0){
                return true;
            }
        }
        return false;
    }

    static bool IsArmstrong(int number, int[] digits){
        int power = digits.Length;
        int sum = 0;
        for (int i = 0; i < digits.Length; i++){
            sum += (int)Math.Pow(digits[i], power);
        }
        return sum == number;
    }

    static int[] FindLargestAndSecondLargest(int[] digits){
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        for (int i = 0; i < digits.Length; i++){
            if (digits[i] > largest){
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest){
                secondLargest = digits[i];
            }
        }
        return new int[] {largest, secondLargest};
    }

    static int[] FindSmallestAndSecondSmallest(int[] digits){
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;
        for (int i = 0; i < digits.Length; i++){
            if (digits[i] < smallest){
                secondSmallest = smallest;
                smallest = digits[i];
            }
            else if (digits[i] < secondSmallest && digits[i] != smallest){
                secondSmallest = digits[i];
            }
        }
        return new int[] {smallest, secondSmallest};
    }
}
