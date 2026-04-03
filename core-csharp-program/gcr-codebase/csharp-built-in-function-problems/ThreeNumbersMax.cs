using System;

class ThreeNumbersMax{
    static void Main(string[] args){
        // Taking input from user
        int num1 = GetNumber("Enter first number: ");
        int num2 = GetNumber("Enter second number: ");
        int num3 = GetNumber("Enter third number: ");

        // Finding maximum number
        int max = FindMaximum(num1, num2, num3);

        Console.WriteLine("\nMaximum of the three numbers is: " + max);

    }

    // Method to take integer input
    static int GetNumber(string message){
        Console.Write(message);
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Method to find maximum of three numbers
    static int FindMaximum(int a, int b, int c){
        int max = a;

        if (b > max){
            max = b;
        }

        if (c > max){
            max = c;
        }

        return max;
    }
}

