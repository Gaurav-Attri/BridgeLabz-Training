using System;
class GcdLcmCalculator{
    static void Main(string[] args){
        int num1 = GetNumber("Enter the first number: ");
        int num2 = GetNumber("Enter the second number: ");

        int gcd = CalculateGCD(num1, num2);

        int lcm = CalculateLCM(num1, num2, gcd);
        DisplayResult(num1, num2, gcd, lcm);

    }

    static int GetNumber(string message){
        Console.Write(message);
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int CalculateGCD(int a, int b){
        while (b != 0){
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int CalculateLCM(int a, int b, int gcd){
        return (a * b) / gcd;
    }

    static void DisplayResult(int a, int b, int gcd, int lcm){
        Console.WriteLine("\nFor numbers " + a + " and " + b + ":");
        Console.WriteLine("GCD = " + gcd);
        Console.WriteLine("LCM = " + lcm);
    }
}

