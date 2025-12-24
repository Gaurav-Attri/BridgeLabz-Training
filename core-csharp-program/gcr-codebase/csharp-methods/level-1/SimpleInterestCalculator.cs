using System;
class SimpleInteresetCalculator{
	static void Main(string[] args){
		Console.WriteLine("Please enter the principal amount: ");
		double principal = double.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the rate value: ");
		double rate = double.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the time value: ");
		double time = double.Parse(Console.ReadLine());
		Console.WriteLine("The simple interest is " + SimpleInterest(principal, rate, time) + " for Principal " + principal + ", Rate of Interest " + rate + " and Time " + time);
	}

	static double SimpleInterest(double principal, double rate, double time){
		double simpleInterest = (principal*rate*time)/100;
		return simpleInterest;
	}
}
