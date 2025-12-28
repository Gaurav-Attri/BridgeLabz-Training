using System;
class PrimeNumberChecker{
    static void Main(string[] args){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Checking whether number is prime
        bool result = IsPrime(number);

        if (result){
            Console.WriteLine("\n" + number + " is a Prime Number.");
        }
        else{
            Console.WriteLine("\n" + number + " is NOT a Prime Number.");
        }
    }

    // Method to check whether a number is prime
    static bool IsPrime(int num){
        if (num <= 1){
            return false;
        }

        for (int i = 2; i <= num / 2; i++){
            if (num % i == 0){
                return false;
            }
        }

        return true;
    }
}

