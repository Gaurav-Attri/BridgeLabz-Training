using System;
class HarryAge{
	static void Main(String[] args){
		string name = "Harry";
		int birthYear = 2000;
		int currentYear = 2024;
		int age = currentYear - birthYear;
		Console.WriteLine(name + "'s age in " + currentYear + " is " + age);
	}
}
