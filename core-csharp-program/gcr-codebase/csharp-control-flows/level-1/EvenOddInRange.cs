using System;
class EvenOddInRange{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		for(int i = 1; i <= num; i++){
			if(i%2 == 0){
				Console.WriteLine(i + " is even");
			}
			else{
				Console.WriteLine(i + " is odd");
			}
		}
	}
}
