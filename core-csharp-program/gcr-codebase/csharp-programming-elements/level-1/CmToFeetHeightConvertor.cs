using System;
class CmToFeetHeightConvertor{
	static void Main(String[] args){
		Console.WriteLine("Please enter your height in cm: ");
		double cmHeight = double.Parse(Console.ReadLine());
		double totalInches = cmHeight / 2.54;
		int feet = (int)(totalInches/12);
		int remainingInches = (int)(totalInches - (feet * 12));
		Console.WriteLine("Your height in cm is " + cmHeight + " while in feet is " + feet + " and inches is " + remainingInches);
	}
}
