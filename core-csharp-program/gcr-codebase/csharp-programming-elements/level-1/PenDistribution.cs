using System;
class PenDistribution{
	static void Main(String[] args){
		int totalPens = 14;
		int totalStudents = 3;
		int penPerStudent = totalPens/totalStudents;
		int remainingPens = totalPens%totalStudents;
		Console.WriteLine("The Pen Per Student is " + penPerStudent + " and the remaining pen not distributed is " + remainingPens);
	}
}
