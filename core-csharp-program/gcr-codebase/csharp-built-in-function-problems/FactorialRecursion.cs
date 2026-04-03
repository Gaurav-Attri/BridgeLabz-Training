using System;
class FactorialRecursion{
    static void Main(string[] args){
        int number = GetInput();

        long factorial = CalculateFactorial(number);

        DisplayResult(number, factorial);

    }

    static int GetInput(){
        Console.Write("Enter a non-negative integer: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static long CalculateFactorial(int n){
        if (n == 0 || n == 1){
            return 1;
        }
        return n * CalculateFactorial(n - 1);
    }

    static void DisplayResult(int num, long factorial){
        Console.WriteLine("\nFactorial of " + num + " is: " + factorial);
    }
}

