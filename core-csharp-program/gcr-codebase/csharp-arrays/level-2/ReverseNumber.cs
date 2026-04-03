using System;
class ReverseNumber{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		
		// Counting the number of digits in the given number
		int temp = num, digitCount = 0;
		while(temp != 0){
			digitCount++;
			temp = temp/10;
		}

		// Extracting digits of the number and storing them in the following array
		int[] digitsArray = new int[digitCount];
		int index = 0;
		while(num != 0){
			int digit = num%10;
			digitsArray[index++] = digit;
			num = num/10;
		}

		// Displaying the digits from the array
		Console.WriteLine("The number " + num + " in reverse is: ");
		for(int i = 0; i < digitCount; i++){
			Console.Write(digitsArray[i]);
		}
	}
}
