using System;
class BMICalculator{
	static void Main(string[] args){
		Console.WriteLine("Please enter your weight: ");
		double weight = double.Parse(Console.ReadLine());
		Console.WriteLine("Please enter your height (in cm): ");
		double height = double.Parse(Console.ReadLine())*0.01;
		double BMI = weight/(height*height);

		if(BMI >= 40){
			Console.WriteLine("Obese");
		}
		else if(BMI >= 25 && BMI <= 39.9){
			Console.WriteLine("Overweight");
		}
		else if(BMI >= 18.5 && BMI <= 24.9){
			Console.WriteLine("Normal");
		}
		else if(BMI <= 18.4){
			Console.WriteLine("Underweight");
		}
	}
}
