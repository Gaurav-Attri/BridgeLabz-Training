using System;
class GradeCalculator{
	static void Main(string[] args){
		Console.WriteLine("Enter Physics marks: ");
		int physics = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Chemistry marks: ");
		int chemistry = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Maths marks: ");
		int maths = int.Parse(Console.ReadLine());
		int obtainedMarks = physics + chemistry + maths;
		int totalMarks = 300;
		double averageMarks = (double)(obtainedMarks)/3;
		double percentage = ((double)(obtainedMarks)/totalMarks)*100;
		if(percentage >= 80){
			Console.WriteLine("Average Marks: " + averageMarks + " and grade A");
		}
		else if(percentage >= 70 && percentage <= 79){
			Console.WriteLine("Average Marks: " + averageMarks + " and grade B");
		}
		else if(percentage >= 60 && percentage <= 69){
			Console.WriteLine("Average Marks: " + averageMarks + " and grade C");
		}
		else if(percentage >= 50 && percentage <= 59){
			Console.WriteLine("Average Marks: " + averageMarks + " and grade D");
		}
		else if(percentage >= 40 && percentage <= 49){
			Console.WriteLine("Average Marks: " + averageMarks + " and grade E");
		}
		else{
			Console.WriteLine("Average Marks: " + averageMarks + " and grade R");
		}
	}
}
