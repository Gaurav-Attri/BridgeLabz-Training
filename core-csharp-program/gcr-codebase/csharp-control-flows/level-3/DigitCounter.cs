using System;
class DigtiCounter{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		int temp = num;
		int digitCount = 0;

		while(temp != 0){
			temp = temp/10;
			digitCount++;
		}

		Console.WriteLine("There are " + digitCount + " digits in " + num);
	}
}
