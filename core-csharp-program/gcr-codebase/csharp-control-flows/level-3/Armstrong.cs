using System;
class Armstrong{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number");
		int num = int.Parse(Console.ReadLine());
		int temp = num; // To preserve the original number
		int sumOfDigitsCubes = 0;

		while(temp != 0){
			int digit = temp%10;
			sumOfDigitsCubes += (int)(Math.Pow(digit, 3));
			temp = temp/10;
		}
		if(sumOfDigitsCubes == num){
			Console.WriteLine("The number " + num + " is armstrong");
		}
		else{
			Console.WriteLine("The number " + num + " is not armstrong");
		}
		
	}
}
