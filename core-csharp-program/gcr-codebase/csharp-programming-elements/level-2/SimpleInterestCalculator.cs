using System;
class SimpleInterestCalculator{
	static void Main(String[] args){
		Console.WriteLine("Please enter the principal amount: ");
		double principal = double.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the rate of interest: ");
		double rate = double.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the time period: ");
		double time = double.Parse(Console.ReadLine());
		double simpleInterest = (principal * rate * time)/100;
		Console.WriteLine("The Simple Interest is " + simpleInterest + " for Principal " + principal + ", Rate of Interest " + rate + " and Time " + time);
	}
}
