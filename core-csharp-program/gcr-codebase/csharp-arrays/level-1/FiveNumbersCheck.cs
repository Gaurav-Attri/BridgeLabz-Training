using System;
class FiveNumbersCheck{
	static void Main(string[] args){
		int[] numbers = new int[5];
		Console.WriteLine("Please enter 5 numbers: ");
		for(int i = 0; i < 5; i++){
			numbers[i] = int.Parse(Console.ReadLine());
		}

		for(int i = 0; i < 5; i++){
			if(numbers[i] == 0){
				Console.WriteLine("The number " + numbers[i] + " is Zero");
			}
			else if(numbers[i] < 0){
				Console.WriteLine("The number " + numbers[i] + " is Negative");
			}
			else{
				if(numbers[i]%2 == 0){
					Console.WriteLine("The number " + numbers[i] + " is Positive and Even");
				}
				else{
					Console.WriteLine("The number " + numbers[i] + " is Positive and Odd");
				}
			}

		}
		if(numbers[0] == numbers[4]){
			Console.WriteLine("First and Last numbers are equal");
		}
		else if(numbers[0] > numbers[4]){
			Console.WriteLine("First number is greater than last number");
		}
		else{
			Console.WriteLine("Last number is greater than first number");
		}
	}
}
