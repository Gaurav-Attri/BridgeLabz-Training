using System;
class ProfitLossNumPerc{
	static void Main(String[] args){
		int costPrice = 129;
		int sellPrice = 191;
		int profit = sellPrice - costPrice;
		float profitPercent = (profit)/((float)(costPrice))*100.0f;
		Console.WriteLine("The Cost Price is INR " + costPrice + " and Selling Price in INR is " + sellPrice + "\nThe Profit in INR is " + profit + " and the Profit Percentage is " + profitPercent);
	}
}
