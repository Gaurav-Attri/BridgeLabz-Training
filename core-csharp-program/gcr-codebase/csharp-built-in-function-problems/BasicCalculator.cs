using System;
class BasicCalculator{
    static void Main(string[] args){

        double num1 = GetNumber("Enter the first number: ");
        double num2 = GetNumber("Enter the second number: ");

        Console.WriteLine("\nChoose an operation:");
        Console.WriteLine("1 - Addition");
        Console.WriteLine("2 - Subtraction");
        Console.WriteLine("3 - Multiplication");
        Console.WriteLine("4 - Division");
        Console.Write("Enter your choice (1-4): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice){
            case 1:
                Console.WriteLine("\nResult: " + num1 + " + " + num2 + " = " + Add(num1, num2));
                break;
            case 2:
                Console.WriteLine("\nResult: " + num1 + " - " + num2 + " = " + Subtract(num1, num2));
                break;
            case 3:
                Console.WriteLine("\nResult: " + num1 + " * " + num2 + " = " + Multiply(num1, num2));
                break;
            case 4:
                if (num2 == 0){
                    Console.WriteLine("\nDivision by zero is not allowed!");
                }
                else{
                    Console.WriteLine("\nResult: " + num1 + " / " + num2 + " = " + Divide(num1, num2));
                }
                break;
            default:
                Console.WriteLine("\nInvalid choice!");
                break;
        }

    }

    static double GetNumber(string message){
        Console.Write(message);
        double number = double.Parse(Console.ReadLine());
        return number;
    }

    static double Add(double a, double b){
        return a + b;
    }

    static double Subtract(double a, double b){
        return a - b;
    }

    static double Multiply(double a, double b){
        return a * b;
    }

    static double Divide(double a, double b){
        return a / b;
    }
}
