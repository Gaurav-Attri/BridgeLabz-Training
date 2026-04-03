using System;
class EarthVolume{
	static void Main(String[] args){
		int earthRadius = 6378;
		double volInCubicKm = (4.0/3.0) * 3.14 * earthRadius*earthRadius*earthRadius;
		double volInCubicMiles = volInCubicKm * 0.2399;
		Console.WriteLine("The volume of earth in cubic kilometer is " + volInCubicKm + " and cubic miles is " + volInCubicMiles);
	}
}
