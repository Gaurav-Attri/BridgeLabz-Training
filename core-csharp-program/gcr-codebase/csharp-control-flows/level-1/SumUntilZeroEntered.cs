using System;
class SunUntilZeroEntered{
	static void Main(string[] args){
		int sum = 0;
		while(true){
			Console.WriteLine("Please enter a number: ");
			int num = int.Parse(Console.ReadLine());
			if(num == 0) break;
			sum += num;
		}
		Console.WriteLine("Sum is: " + sum);
	}
}
