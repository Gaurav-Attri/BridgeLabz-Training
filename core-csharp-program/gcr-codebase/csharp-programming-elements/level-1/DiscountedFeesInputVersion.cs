using System;
class DiscountedFessInputVersion{
	static void Main(String[] args){
		Console.WriteLine("Please enter the fees amount: ");
		double fees = double.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the discount percentange: ");
		double discountPercent = double.Parse(Console.ReadLine());
		double discount = fees*(discountPercent/100);
		double discountedFees = fees - discount;
		Console.WriteLine("The discount amount is INR " + discount + " and final discounted fees is INR " + discountedFees);
	}
}
