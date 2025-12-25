using System;

class NumberCheckerV5{
    static void Main(string[] args){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.WriteLine("Greatest Factor: " + FindGreatestFactor(factors));
        Console.WriteLine("Sum of Factors: " + FindSumOfFactors(factors));
        Console.WriteLine("Product of Factors: " + FindProductOfFactors(factors));
        Console.WriteLine("Product of Cube of Factors: " + FindProductOfCubeOfFactors(factors));

        if (IsPerfect(number, factors)){
            Console.WriteLine("Perfect Number");
        }
        else{
            Console.WriteLine("Not a Perfect Number");
        }

        if (IsAbundant(number, factors)){
            Console.WriteLine("Abundant Number");
        }
        else{
            Console.WriteLine("Not an Abundant Number");
        }

        if (IsDeficient(number, factors)){
            Console.WriteLine("Deficient Number");
        }
        else{
            Console.WriteLine("Not a Deficient Number");
        }

        if (IsStrong(number)){
            Console.WriteLine("Strong Number");
        }
        else{
            Console.WriteLine("Not a Strong Number");
        }
    }

    static int[] FindFactors(int num){
        int count = 0;

        for (int i = 1; i <= num; i++){
            if (num % i == 0){
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= num; i++){
            if (num % i == 0){
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    static int FindGreatestFactor(int[] factors){
        int max = Int32.MinValue;

        for (int i = 0; i < factors.Length; i++){
            if (factors[i] > max){
                max = factors[i];
            }
        }

        return max;
    }

    static int FindSumOfFactors(int[] factors){
        int sum = 0;

        for (int i = 0; i < factors.Length; i++){
            sum += factors[i];
        }

        return sum;
    }

    static long FindProductOfFactors(int[] factors){
        long product = 1;

        for (int i = 0; i < factors.Length; i++){
            product *= factors[i];
        }

        return product;
    }

    static double FindProductOfCubeOfFactors(int[] factors){
        double product = 1;

        for (int i = 0; i < factors.Length; i++){
            product *= Math.Pow(factors[i], 3);
        }

        return product;
    }

    static bool IsPerfect(int num, int[] factors){
        int sum = 0;

        for (int i = 0; i < factors.Length - 1; i++){
            sum += factors[i];
        }

        return sum == num;
    }

    static bool IsAbundant(int num, int[] factors){
        int sum = 0;

        for (int i = 0; i < factors.Length - 1; i++){
            sum += factors[i];
        }

        return sum > num;
    }

    static bool IsDeficient(int num, int[] factors){
        int sum = 0;

        for (int i = 0; i < factors.Length - 1; i++){
            sum += factors[i];
        }

        return sum < num;
    }

    static bool IsStrong(int num){
        int temp = num;
        int sum = 0;

        while (temp > 0){
            int digit = temp % 10;
            sum += Factorial(digit);
            temp = temp / 10;
        }

        return sum == num;
    }

    static int Factorial(int n){
        int fact = 1;

        for (int i = 1; i <= n; i++){
            fact *= i;
        }

        return fact;
    }
}

