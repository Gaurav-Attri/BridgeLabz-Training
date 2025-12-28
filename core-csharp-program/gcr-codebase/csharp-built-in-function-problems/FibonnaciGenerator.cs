using System;
class FibonacciSequence{
    static void Main(string[] args){

        // Taking input from user
        Console.Write("Enter the number of terms: ");
        int terms = int.Parse(Console.ReadLine());

        // Generating Fibonacci sequence
        GenerateFibonacci(terms);

    }

    // Method to generate and display Fibonacci sequence
    static void GenerateFibonacci(int n){
        int first = 0;
        int second = 1;
        int next;

        Console.WriteLine("\nFibonacci Sequence:");

        if (n >= 1){
            Console.Write(first);
        }

        if (n >= 2){
            Console.Write(" " + second);
        }

        for (int i = 3; i <= n; i++){
            next = first + second;
            Console.Write(" " + next);

            first = second;
            second = next;
        }

        Console.WriteLine();
    }
}

