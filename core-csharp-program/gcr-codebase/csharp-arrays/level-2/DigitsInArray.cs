using System;
class DigitsInArray{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		int[] digits = new int[10];
		int index = 0;

		while(num != 0 && index < 10){
			int digit = num%10;
			digits[index++] = digit;
			num = num/10;
		}

		// finding the largest and second largest digit in the digits array
		int largest = int.MinValue;
		int secondLargest = int.MinValue;

		for(int i = 0; i < index; i++){
			if(digits[i] > largest){
				secondLargest = largest;
				largest = digits[i];
			}
			else if(digits[i] > secondLargest && digits[i] != largest){
				secondLargest = digits[i];
			}
		}

		Console.WriteLine("Largest digit is: " + largest);
		Console.WriteLine("Second Largest digit is: " + secondLargest);
	}
}
