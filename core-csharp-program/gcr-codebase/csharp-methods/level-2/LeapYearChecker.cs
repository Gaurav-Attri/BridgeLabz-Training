using System;
class LeapYearChecker{
	static void Main(string[] args){
		Console.WriteLine("Please enter a year >= 1582");
		int year = int.Parse(Console.ReadLine());

		// If year is < 1582, then the program exits
		if(year < 1582) System.Environment.Exit(1);

		Console.WriteLine(year + " is a leap year? " + IsLeapYear(year));
	}

	static bool IsLeapYear(int year){
		return (year%400 == 0) || (year%4 == 0 && year%100 != 0);
	}
}
