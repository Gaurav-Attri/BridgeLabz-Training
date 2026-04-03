using System;
class FizzBuzz2{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		if(num <= 0){
			Console.WriteLine("Please enter a positive number only.");
		}
		else{
			int i = 0;
			while(i <= num){
				if(i%3 == 0 && i%5 == 0){
					Console.WriteLine("FizzBuzz");
				}
				else if(i%5 == 0){
					Console.WriteLine("Buzz");
				}
				else if(i%3 == 0){
					Console.WriteLine("Fizz");
				}
				i++;
			}
		}
	}
}
