using System;
class PurchasedItemAmtCacl{
	static void Main(String[] args){
		Console.WriteLine("Please enter unit price: ");
		double unitPrice = double.Parse(Console.ReadLine());
		Console.WriteLine("Please enter quantity ");
		double quantity = double.Parse(Console.ReadLine());
		double amount = unitPrice*quantity;
		Console.WriteLine("The total purchase price is INR " + amount + " if the quantity " + quantity + " and unit price is INR " + unitPrice);
	}
}
