using System;
class UnitConvertorV2{
	static void Main(string[] args){
		Console.WriteLine("5 yards is equal to " + YardsToFeet(5) + " feet");
		Console.WriteLine("5 feet is equal to " + FeetToYards(5) + " yards");
		Console.WriteLine("5 meters is equal to " + MetersToInches(5) + " inches");
		Console.WriteLine("5 inches is equal to " + InchesToCentimeter(5) + " centimeter");
	}

	static double YardsToFeet(double yards){
		return yards*3;
	}

	static double FeetToYards(double feet){
		return feet*0.33333;
	}

	static double MetersToInches(double meters){
		return meters*39.3701;
	}

	static double InchesToCentimeter(double inches){
		return inches*2.54;
	}
}
