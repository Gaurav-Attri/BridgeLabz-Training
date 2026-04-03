using System;
class DayOfWeek{
	static void Main(string[] args){
		Console.WriteLine("Please enter month value (1 for Jan, 2 for Feb...");
		int month = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter day");
		int day = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter year");
		int year = int.Parse(Console.ReadLine());

		// Using Following formulae to calculte the day
		// y0 = y - (14-m)/12
		// x = y0 + y0/4 - y0/100 + y0/400
		// m0 = m + 12 * ((14-m)/12) - 2
		// d0 = (d + x + 31m0/12) mod 7
		
		int y0 = year - (14 - month) / 12;
		int x = y0 + y0/4 - y0/100 + y0/400;
		int m0 = month + 12 * ((14 - month) / 12) - 2;
		int d0 = (day + x + (31*m0)/12)%7;

		Console.WriteLine("Day corresponding to " + month + "/" + day + "/" + year + " is " + d0);
	}
}
