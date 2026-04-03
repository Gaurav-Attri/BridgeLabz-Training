using System;
class RestrictedMuliplicationTable{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number in the range of 6 to 9: ");
		int number = int.Parse(Console.ReadLine());
		if(number < 6 || number > 9){
			Console.WriteLine("The number MUST BE in the range of 6 to 9 only");
		}
		else{
			int[] table = new int[11];

			for(int i = 1; i < 11; i++){
				table[i] = number*i;
			}

			for(int i = 1; i < 11; i++){
				Console.WriteLine(number + "*" + i + "=" + table[i]);
			}
		}
	}
}
