using System;
class NumbersAndTheirSum{
	static void Main(string[] args){
		double[] arr = new double[10]; // arr can store upto 10 numbers
		double sum = 0.0;
		int endIndex = 0;

		Console.WriteLine("Enter numbers: ");
		for(int i = 0; i < 10; i++){
			double num = double.Parse(Console.ReadLine());
			if(num <= 0) break;
			arr[i] = num;
			sum += num;
			endIndex = i;
		}


		Console.WriteLine("Numbers are: ");
		for(int i = 0; i <= endIndex; i++){
			Console.WriteLine(arr[i]);
		}

		Console.WriteLine("\nTheir sum is: " + sum);
	}
}
