using System;
class TemperatureConverter{
    static void Main(string[] args){

        Console.WriteLine("Choose conversion type:");
        Console.WriteLine("1 - Celsius to Fahrenheit");
        Console.WriteLine("2 - Fahrenheit to Celsius");
        Console.Write("Enter your choice (1 or 2): ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1){
            double celsius = GetTemperature("Enter temperature in Celsius: ");
            double fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine("\n" + celsius + "°C = " + fahrenheit + "°F");
        }
        else if (choice == 2){
            double fahrenheit = GetTemperature("Enter temperature in Fahrenheit: ");
            double celsius = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine("\n" + fahrenheit + "°F = " + celsius + "°C");
        }
        else{
            Console.WriteLine("\nInvalid choice!");
        }

    }

    static double GetTemperature(string message){
        Console.Write(message);
        double temp = double.Parse(Console.ReadLine());
        return temp;
    }

    static double CelsiusToFahrenheit(double celsius){
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double fahrenheit){
        return (fahrenheit - 32) * 5 / 9;
    }
}
