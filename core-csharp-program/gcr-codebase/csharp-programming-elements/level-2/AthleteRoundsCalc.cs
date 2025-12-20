using System;
class AthleteRoundsCalc{
	static void Main(String[] args){
		Console.WriteLine("Please enter the 3 sides length of the triangular park, each on different line: ");
		double side1 = double.Parse(Console.ReadLine())*0.001;
		double side2 = int.Parse(Console.ReadLine())*0.001;
		double side3 = int.Parse(Console.ReadLine())*0.001;
		double perimeter = side1 + side2 + side3;
		double totalRounds = 5 / perimeter;
		Console.WriteLine("The total number of rounds the athlete will run is " + totalRounds + " to complete 5 km");
	}
}
