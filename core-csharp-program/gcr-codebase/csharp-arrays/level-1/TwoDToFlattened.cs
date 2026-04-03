using System;
class TwoDToFlattened{
	static void Main(string[] args){
		Console.WriteLine("Please enter the number of rows: ");
		int rows = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the number of columns: ");
		int columns = int.Parse(Console.ReadLine());

		// Creating a 2D array
		int[,] matrix = new int[rows, columns];

		// Taking user input
		Console.WriteLine("Please enter " + (rows*columns) + " numbers, each on a different line");
		for(int i = 0; i < rows; i++){
			for(int j = 0; j < columns; j++){
				matrix[i, j] = int.Parse(Console.ReadLine());
			}
		}
		
		// Creating a 1D array
		int[] arr = new int[rows*columns];
		int ind = 0;
		for(int i = 0; i < rows; i++){
			for(int j = 0; j < columns; j++){
				arr[ind++] = matrix[i, j];
			}
		}

		Console.WriteLine("The flattened array is: ");
		for(int i = 0; i < arr.Length; i++){
			Console.WriteLine(arr[i]);
		}

	}
}
