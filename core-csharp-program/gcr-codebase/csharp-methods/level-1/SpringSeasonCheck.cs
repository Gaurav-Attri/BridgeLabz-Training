using System;
class SpringSeasonCheck{
	static void Main(string[] args){
		Console.WriteLine("Please enter the month value (1 for Jan, 2 for Feb, etc): ");
		int month = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the day: ");
		int day = int.Parse(Console.ReadLine());
		if(IsSpringSeason(month, day)) Console.WriteLine("It's a Spring Season");
		else Console.WriteLine("Not a Spring Season");
	}

	static bool IsSpringSeason(int month, int day){
		return ((month >= 3 && month <= 6) && (day >= 1 && day <= 20));
	}
}
