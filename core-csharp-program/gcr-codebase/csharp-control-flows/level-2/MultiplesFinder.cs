using System;
class MultiplesFinder{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		int multiple = num*1;
		int i = 2;

		while(multiple <= 100){
			Console.WriteLine(multiple + " is a multiple");
			multiple = num*i;
			i++;
		}
	}
}
