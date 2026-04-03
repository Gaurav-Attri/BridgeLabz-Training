using System;
class LeapYear{
	static void Main(string[] args){
		Console.WriteLine("Please enter a year: ");
		int year = int.Parse(Console.ReadLine());
		if(year < 1582){
			Console.WriteLine("Invalid input. Input years >= 1582");
		}
		else{
			if(year%4 == 0 && year%100 != 0){
				Console.WriteLine("The year " + year + " is a leap year");
			}
			else if(year%400 == 0){
				Console.WriteLine("The year " + year + " is a leap year");
			}
			else{
				Console.WriteLine("The year " + year + " is not a leap year");
			}
		}
	}
}
