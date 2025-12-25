using System;
class NumberCheckerV4{
    static void Main(string[] args){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number)){
            Console.WriteLine("Prime Number");
        }
        else{
            Console.WriteLine("Not a Prime Number");
        }

        if (IsNeon(number)){
            Console.WriteLine("Neon Number");
        }
        else{
            Console.WriteLine("Not a Neon Number");
        }

        if (IsSpy(number)){
            Console.WriteLine("Spy Number");
        }
        else{
            Console.WriteLine("Not a Spy Number");
        }

        if (IsAutomorphic(number)){
            Console.WriteLine("Automorphic Number");
        }
        else{
            Console.WriteLine("Not an Automorphic Number");
        }

        if (IsBuzz(number)){
            Console.WriteLine("Buzz Number");
        }
        else{
            Console.WriteLine("Not a Buzz Number");
        }
    }

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

    static bool IsNeon(int num){
        int square = num * num;
        int sum = 0;

        while (square > 0){
            sum += square % 10;
            square = square / 10;
        }

        return sum == num;
    }

    static bool IsSpy(int num){
        int sum = 0;
        int product = 1;

        while (num > 0){
            int digit = num % 10;
            sum += digit;
            product *= digit;
            num = num / 10;
        }

        return sum == product;
    }

    static bool IsAutomorphic(int num){
        int square = num * num;
        int temp = num;

        while (temp > 0){
            if (temp % 10 != square % 10){
                return false;
            }

            temp = temp / 10;
            square = square / 10;
        }
        return true;
    }

    static bool IsBuzz(int num){
        if (num % 7 == 0 || num % 10 == 7){
            return true;
        }

        return false;
    }
}

