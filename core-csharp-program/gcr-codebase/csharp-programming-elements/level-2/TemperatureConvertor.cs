using System;
class TemperatureConvertor{
	static void Main(String[] args){
		Console.WriteLine("Please enter the temperature in Celcius: ");
		double tempInCelsius = double.Parse(Console.ReadLine());
		double tempInFahren = (tempInCelsius * 9.0/5.0) + 32;
		Console.WriteLine("The " + tempInCelsius + " Celsius is " + tempInFahren + " Fahrenheit");
	}
}
