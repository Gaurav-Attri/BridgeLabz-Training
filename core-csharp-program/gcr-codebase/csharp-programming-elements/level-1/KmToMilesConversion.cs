using System;
class KmToMilesConversion{
	static void Main(String[] args){
		Console.WriteLine("Please Enter the distance in km: ");
		double km = double.Parse(Console.ReadLine());
		double miles = km*0.6213;
		Console.WriteLine("The total miles is " + miles + " mile for the given " + km + "km");
	}
}
