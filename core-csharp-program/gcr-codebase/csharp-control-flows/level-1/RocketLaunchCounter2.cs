using System;
class RocketLaunchCounter2{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int counter = int.Parse(Console.ReadLine());
		for(; counter >= 1; counter--){
			Console.WriteLine(counter);
		}
	}
}
