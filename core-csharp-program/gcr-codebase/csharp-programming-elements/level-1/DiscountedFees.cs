using System;
class DiscountedFess{
	static void Main(String[] args){
		int fee = 125000;
		float discountPercent = 10;
		float discount = fee*(discountPercent/100);
		float discountedFees = fee - discount;
		Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + discountedFees);
	}
}
