using System;
class PrimalityTest{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		// Logic to check if the given number is prime or not
		bool prime = true; // intitially, we're considering the number is prime. 
		for(int i = 2; i < num; i++){
			if(num%i == 0){
				prime = false;
				break;
			}
		}

		if(num == 1 || num == 0){
			Console.WriteLine("Not Prime");
		}
		else if(num == 2 || prime){
			Console.WriteLine("Prime");
		}
		else{
			Console.WriteLine("Not Prime");
		}
	}
}
