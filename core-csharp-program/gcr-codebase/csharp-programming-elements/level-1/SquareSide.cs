using System;
class SquareSide{
	static void Main(String[] args){
		Console.WriteLine("Please enter the perimeter of the square");
		int perimeter = int.Parse(Console.ReadLine());
		int side = perimeter/4;
		Console.WriteLine("The length of the side is " + side + " whose perimeter is " + perimeter);
	}
}
