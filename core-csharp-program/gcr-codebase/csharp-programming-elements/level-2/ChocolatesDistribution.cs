using System;
class ChocolatesDistribution{
	static void Main(String[] args){
		Console.WriteLine("Please enter the number of Chocolates: ");
		int chocolatesCount = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the number of Children: ");
		int childrenCount = int.Parse(Console.ReadLine());
		int chocolatePerChild = chocolatesCount / childrenCount;
		int remainingChocolates = chocolatesCount % childrenCount;
		Console.WriteLine("The number of chocolates each child gets is " + chocolatePerChild + " and the number of remaining chocolates is " + remainingChocolates);
	}
}
