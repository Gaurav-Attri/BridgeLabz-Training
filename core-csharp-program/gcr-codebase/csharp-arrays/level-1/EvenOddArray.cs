using System;
class EvenOddArray{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		if(num <= 0){
			Console.WriteLine("Please enter a natural number only.");
		}
		else{
			int[] even = new int[num/2];
			int[] odd = new int[num/2];
			int oddInd = 0, evenInd = 0;
			for(int i = 1; i <= num; i++){
				if(i%2 == 0){
					even[evenInd++] = i;
				}
				else{
					odd[oddInd++] = i;
				}
			}


			Console.WriteLine("Even Number array: ");
			for(int i = 0; i < even.Length; i++){
				Console.WriteLine(even[i]);
			}

			Console.WriteLine("\nOdd Number array: ");
			for(int i = 0; i < odd.Length; i++){
				Console.WriteLine(odd[i]);
			}
		}
	}	
}
