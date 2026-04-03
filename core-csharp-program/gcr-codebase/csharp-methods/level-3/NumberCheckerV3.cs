using System;
class NumberCheckerV3{
    static void Main(string[] args){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int count = CountDigits(number);
        int[] digits = StoreDigits(number, count);

        int[] reversedDigits = ReverseDigits(digits);

        if (AreArraysEqual(digits, reversedDigits)){
            Console.WriteLine("The number is a Palindrome");
        }
        else{
            Console.WriteLine("The number is NOT a Palindrome");
        }

        if (IsDuckNumber(digits)){
            Console.WriteLine("The number is a Duck Number");
        }
        else{
            Console.WriteLine("The number is NOT a Duck Number");
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

    static int[] ReverseDigits(int[] digits){
        int[] reversed = new int[digits.Length];
        int index = 0;
        for (int i = digits.Length - 1; i >= 0; i--){
            reversed[index] = digits[i];
            index++;
        }
        return reversed;
    }

    static bool AreArraysEqual(int[] arr1, int[] arr2){
        if (arr1.Length != arr2.Length){
            return false;
        }

        for (int i = 0; i < arr1.Length; i++){
            if (arr1[i] != arr2[i]){
                return false;
            }
        }
        return true;
    }

    static bool IsDuckNumber(int[] digits){
        for (int i = 0; i < digits.Length; i++){
            if (digits[i] != 0){
                return true;
            }
        }
        return false;
    }
}
