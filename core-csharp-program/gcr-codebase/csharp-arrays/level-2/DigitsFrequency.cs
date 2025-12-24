using System;
class DigitsFrequency{
	static void Main(string[] args){
		Console.WriteLine("Please enter a number: ");
		int num = int.Parse(Console.ReadLine());
		// Digits Frequency array
		int[] freq = new int[10];

		// If the given number itself is zero then the frequency of 0 is 1
		if(num == 0) freq[0]++;

		// Counting frequency of digits by extracting digits from the number
		while(num != 0){
			freq[num%10]++;
			num = num/10;
		}

		// Displaying the frequency
		Console.WriteLine("Frequencies of different digits are as follows: ");
		for(int i = 0; i < 10; i++){
			Console.WriteLine(i + "->" + freq[i]);
		}
	}
}
