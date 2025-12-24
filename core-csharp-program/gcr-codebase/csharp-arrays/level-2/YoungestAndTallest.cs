using System;
class YoungestAndTallest{
	static void Main(string[] args){
		double[] heights = new double[3];
		double[] ages = new double[3];
		int youngestIndex = 0, tallestIndex = 0;

		Console.WriteLine("Please enter Amar's age and height respectively: ");
		ages[0] = double.Parse(Console.ReadLine());
		heights[0] = double.Parse(Console.ReadLine());
		
		Console.WriteLine("Please enter Akbar's age and height respectively: ");
		ages[1] = double.Parse(Console.ReadLine());
		heights[1] = double.Parse(Console.ReadLine());

		Console.WriteLine("Please enter Anthony's age and height respectively: ");
		ages[2] = double.Parse(Console.ReadLine());
		heights[2] = double.Parse(Console.ReadLine());

		for(int i = 1; i < 3; i++){
			if(ages[i] < ages[youngestIndex]){
				youngestIndex = i;
			}
			if(heights[i] > heights[tallestIndex]){
				tallestIndex = i;
			}
		}
		
		// Finding the youngest
		if(youngestIndex == 0){
			Console.WriteLine("Amar is the Youngest");
		}
		else if(youngestIndex == 1){
			Console.WriteLine("Akbar is the Youngest");
		}
		else{
			Console.WriteLine("Anthony is the Youngest");
		}

		// Finding the tallest
		if(tallestIndex == 0){
			Console.WriteLine("Amar is the tallest");
		}
		else if(tallestIndex == 1){
			Console.WriteLine("Akbar is the tallest");
		}
		else{
			Console.WriteLine("Anthony is the tallest");
		}
	}
}
