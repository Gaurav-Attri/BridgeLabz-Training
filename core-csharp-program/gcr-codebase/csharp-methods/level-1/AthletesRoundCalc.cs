using System;
class AthletesRoundCalc{
	static void Main(string[] args){
		Console.WriteLine("Please enter 3 sides of the triangular park: ");
		double side1 = double.Parse(Console.ReadLine());
		double side2 = double.Parse(Console.ReadLine());
		double side3 = double.Parse(Console.ReadLine());
		Console.WriteLine("In order to complete 5 km, the Athlete need to complete " + CountRounds(side1, side2, side3) + " rounds");
	}

	static double CountRounds(double side1, double side2, double side3){
		double distanceToCover = 5000;
		double perimeter = (side1 + side2 + side3);
		double rounds = distanceToCover/perimeter;
		return rounds;
	}
}
