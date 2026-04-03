using System;
class YardMilesDistance{
	static void Main(String[] args){
		Console.WriteLine("Please enter the distance in feet ");
		double feet = double.Parse(Console.ReadLine());
		double miles = feet*0.000189394;
		double yards = feet*0.333333;
		Console.WriteLine("The " + feet + " feet distance in yard is " + yards + " yards and miles is " + miles + " miles");
	}
}
