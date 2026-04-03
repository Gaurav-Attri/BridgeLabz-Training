using System;

class BusRoute{
	private double totalDistance = 0;

	public void StartJourney(){
		Console.WriteLine("Your Bus Journey starts now....\n");

		while(true){
			Console.Write("Enter distance for the next stop (in km): ");
			double distance = double.Parse(Console.ReadLine());
			totalDistance += distance;

			Console.WriteLine("Total Distance covered so far: " + this.totalDistance);
			Console.Write("Do you want to get off at this stop? (yes/no): ");
			string choice = Console.ReadLine().ToLower();

			if(choice == "yes"){
				Console.WriteLine("You got off the bus.");
				Console.WriteLine("Total distance travelled: " + this.totalDistance + " km");
				break;
			}
		}
	}
}

class BusRouteDistanceTracker{
	static void Main(string[] args){
		BusRoute busRoute = new BusRoute();
		busRoute.StartJourney();
	}
}
