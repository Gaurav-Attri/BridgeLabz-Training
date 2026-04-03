using System;
class TravelComputation{
	static void Main(String[] args){
		Console.WriteLine("Please enter the name of the person travelling: ");
		String name = Console.ReadLine();

		// Taking City names inputs
		Console.WriteLine("Please enter the starting city: ");
		String fromCity = Console.ReadLine();
		Console.WriteLine("Please enter the via city: ");
		String viaCity = Console.ReadLine();
		Console.WriteLine("Please enter the final (destination) city: ");
		String toCity = Console.ReadLine();

		// Taking city distances inputs
		Console.WriteLine("Please enter the distance from starting to via city: ");
		double distanceFromToVia = double.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the distance from via to final city: ");
		double distanceViaToFinal = double.Parse(Console.ReadLine());

		// Taking travel time inputs in minutes
		Console.WriteLine("Please enter the travel time from starting to via city (in minutes): ");
		int timeFromToVia = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the travel time from via to final city (in minutes): ");
		int timeViaToFinal = int.Parse(Console.ReadLine());

		// Computing total distance and total time
		double totalDistance = distanceFromToVia + distanceViaToFinal;
		int totalTime = timeFromToVia + timeViaToFinal;

		// Finally, printing the result
		Console.WriteLine("The Total Distance Travelled by " + name + " from " + fromCity + " to " + toCity + " via " + viaCity + " is " + totalDistance + " km and the Total Time taken is " + totalTime + " minutes");
	}
}
