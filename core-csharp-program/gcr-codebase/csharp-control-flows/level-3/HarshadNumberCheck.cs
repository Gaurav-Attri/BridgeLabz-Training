using System;
class HarshadNumberCheck{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		int temp = num; // To preserve the original num
		// Calculating the sum of num's digits
		int sum = 0;
		while(temp != 0){
			sum += temp%10;
			temp = temp/10;
		}

		// Checking if num is Harshad number
		if(num%sum == 0){
			Console.WriteLine("The number " + num + " is a Harshad Number");
		}
		else{
			Console.WriteLine("The number " + num + " is not a Harshad Number");
		}

	}
}
