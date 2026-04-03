using System;
class YoungestAndTallest{
	static void Main(string[] args){
		int[] ages = new int[3];
		int[] heights = new int[3];

		Console.WriteLine("Enter ages of Amar, Akbar and Anthony, respectively: ");
		for(int i = 0; i < 3; i++) ages[i] = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter heights of Amar, Akbar and Anthony, respectively: ");
		for(int i = 0; i < 3; i++) heights[i] = int.Parse(Console.ReadLine());

		// Displaying the youngest
		int youngestIndex = Youngest(ages);
		if(youngestIndex == 0) Console.WriteLine("Amar is Youngest");
		else if(youngestIndex == 1) Console.WriteLine("Akbar is Youngest");
		else Console.WriteLine("Anthony is Youngest");

		// Displaying the tallest
		int tallestIndex = Tallest(heights);
		if(tallestIndex == 0) Console.WriteLine("Amar is Tallest");
		else if(tallestIndex == 1) Console.WriteLine("Akbar is Tallest");
		else Console.WriteLine("Anthony is Tallest");
	}

	static int Youngest(int[] ages){
		int youngestIndex = 0;
		for(int i = 1; i < 3; i++){
			if(ages[i] < ages[youngestIndex]) youngestIndex = i;
		}
		return youngestIndex;
	}

	static int Tallest(int[] heights){
		int tallestIndex = 0;
		for(int i = 1; i < 3; i++){
			if(heights[i] > heights[tallestIndex]) tallestIndex = i;
		}
		return tallestIndex;
	}
}
