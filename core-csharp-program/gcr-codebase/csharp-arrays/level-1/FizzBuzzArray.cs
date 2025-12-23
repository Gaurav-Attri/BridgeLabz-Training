using System;
class FizzBuzzArray{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		if(num <= 0){
			Console.WriteLine("Please enter a positive number");
		}
		else{
			string[] arr = new string[num+1];
			for(int i = 0; i < arr.Length; i++){
				if(i%3 == 0 && i%5 == 0){
					arr[i] = "FizzBuzz";
				}
				else if(i%5 == 0){
					arr[i] = "Buzz";
				}
				else if(i%3 == 0){
					arr[i] = "Fizz";
				}
				else{
					arr[i] = ""+i;
				}

			}

			for(int i = 0; i < arr.Length; i++){
				Console.WriteLine("Position " + i + " = " + arr[i]);
			}
		}
	}
}
