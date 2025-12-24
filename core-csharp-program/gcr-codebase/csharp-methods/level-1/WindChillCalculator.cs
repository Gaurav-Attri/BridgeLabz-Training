using System;
class WindChillCalculator{
	static void Main(string[] args){
		Console.WriteLine("Please enter the temperature: ");
		double temperature = double.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the wind speed: ");
		double windSpeed = double.Parse(Console.ReadLine());
		Console.WriteLine("Wind Chill Temperature is: " + WindChillTemp(temperature, windSpeed));
	}

	static double WindChillTemp(double temperature, double windSpeed){
		double windChill = 35.74 + 0.6215*temperature + (0.4275*temperature - 35.75)*windSpeed*0.16;
		return windChill;
	}
}
