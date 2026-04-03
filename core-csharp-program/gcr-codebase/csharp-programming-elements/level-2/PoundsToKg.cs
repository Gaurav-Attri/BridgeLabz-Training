using System;
class PoundsToKg{
	static void Main(String[] args){
		Console.WriteLine("Please enter the weight in pounds: ");
		double pounds = double.Parse(Console.ReadLine());
		double kg = pounds*0.453592;
		Console.WriteLine("The weight of person in pounds is " + pounds + " and in kg is " + kg);
	}
}
