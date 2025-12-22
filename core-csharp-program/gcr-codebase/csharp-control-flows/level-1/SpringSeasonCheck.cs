using System;
class SpringSeasonCheck{
	static void Main(string[] args){
		Console.WriteLine("Please enter the value of the month in number: ");
		int month = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the day in number: ");
		int day = int.Parse(Console.ReadLine());
		if((month >= 3 && month <= 6) && (day >= 1 && day <= 20)){
			Console.WriteLine("Its a Spring Season");
		}
		else{
			Console.WriteLine("Not a Spring Season");
		}
	}
}
