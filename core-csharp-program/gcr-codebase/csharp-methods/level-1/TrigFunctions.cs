using System;
class TrigFunctions{
	static void Main(string[] args){
		Console.WriteLine("Please enter the angle in degrees: ");
		double angle = double.Parse(Console.ReadLine())*Math.PI/180; // Converting degrees to radians
		double[] results = CalcTrigFunctions(angle);
		Console.WriteLine("Sine function's value is: " + results[0]);
		Console.WriteLine("Cosine function's value is: " + results[1]);
		Console.WriteLine("Tangent function's value is: " + results[2]);
	}

	static double[] CalcTrigFunctions(double angle){
		return new double[] {Math.Sin(angle), Math.Cos(angle), Math.Tan(angle)};
	}
}
