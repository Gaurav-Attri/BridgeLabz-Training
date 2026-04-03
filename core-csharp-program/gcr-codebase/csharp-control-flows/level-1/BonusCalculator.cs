using System;
class BonusCalculator{
	static void Main(string[] args){
		Console.WriteLine("Please enter your salary: ");
		double salary = double.Parse(Console.ReadLine());
		Console.WriteLine("Please enter your total years of experience: ");
		double yearsOfExp = double.Parse(Console.ReadLine());
		double bonus = (yearsOfExp/100)*salary;
		Console.WriteLine("Your bonus is: " + bonus);
	}
}
