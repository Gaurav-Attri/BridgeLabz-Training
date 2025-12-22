using System;
class FizzBuzz{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		if(num <= 0){
			Console.WriteLine("Please enter a positive number only.");
		}
		else{
			for(int i = 0; i <= num; i++){
				if(i%3 == 0 && i%5 == 0){
					Console.WriteLine("FizzBuzz");
				}
				else if(i%5 == 0){
					Console.WriteLine("Buzz");
				}
				else if(i%3 == 0){
					Console.WriteLine("Fizz");
				}
			}
		}
	}
}
