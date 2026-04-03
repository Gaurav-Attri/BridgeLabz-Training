using System;
class UnitConvertor{
	static void Main(string[] args){
		Console.WriteLine("5 km is equal to " + KmToMiles(5) + " miles");
		Console.WriteLine("5 miles is equal to " + MilesToKm(5) + " km");
		Console.WriteLine("5 meters is equal to " + MetersToFeet(5) + " feet");
		Console.WriteLine("5 feet is equal to " + FeetToMeters(5) + " meters");
	}

	static double KmToMiles(double km){
		return km*0.621371;
	}

	static double MilesToKm(double miles){
		return miles*1.60934;
	}

	static double MetersToFeet(double meters){
		return meters*3.28084;
	}

	static double FeetToMeters(double feet){
		return feet*0.3048;
	}
}
