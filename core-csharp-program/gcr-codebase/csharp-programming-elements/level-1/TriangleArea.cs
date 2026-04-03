using System;
class TriangleArea{
	static void Main(String[] args){
		Console.WriteLine("Please enter triangle's base: ");
		double triangleBase = double.Parse(Console.ReadLine());
		Console.WriteLine("Please enter triangle's height: ");
		double triangleHeight = double.Parse(Console.ReadLine());
		double area = 0.5*triangleBase*triangleHeight;
		double areaInCmSquare = area*6.4516;
		Console.WriteLine("Area of the triangle in square inches is " + area + " and area in square cm is " + areaInCmSquare);
	}
}
