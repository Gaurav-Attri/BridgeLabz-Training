using System;
class RocketLaunchCounter{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number");
		int counter = int.Parse(Console.ReadLine());
		while(counter >= 1){
			Console.WriteLine(counter--);
		}
	}
}
