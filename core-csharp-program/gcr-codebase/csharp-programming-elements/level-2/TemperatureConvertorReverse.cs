using System;
class TemperatureConvertorReverse{
	static void Main(String[] args){
		Console.WriteLine("Please enter the temperature in Fahrenheit: ");
		double tempInFahren = double.Parse(Console.ReadLine());
		double tempInCelsius = (tempInFahren - 32) * (5.0/9.0);
		Console.WriteLine("The " + tempInFahren + " Fahrenheit is " + tempInCelsius + " Celsius");
	}
}
