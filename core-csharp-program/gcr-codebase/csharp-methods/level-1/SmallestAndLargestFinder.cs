using System;
class SmallestAndLargestFinder{
	static void Main(string[] args){
		Console.WriteLine("Please enter 3 numbers, each on a separate line: ");
		int[] numbersArray = new int[3];
		for(int i = 0; i < 3; i++) numbersArray[i] = int.Parse(Console.ReadLine());
		int[] smallestAndLargest = FindSmallestAndLargest(numbersArray);
		Console.WriteLine("Smallest is: " + smallestAndLargest[0]);
		Console.WriteLine("Largest is: " + smallestAndLargest[1]);
	}

	static int[] FindSmallestAndLargest(int[] numbersArray){
		int largest = numbersArray[0];
		int smallest = numbersArray[1];

		for(int i = 1; i < 3; i++){
			if(numbersArray[i] > largest) largest = numbersArray[i];
			if(numbersArray[i] < smallest) smallest = numbersArray[i];
		}

		return new int[]{smallest, largest};
	}
}
