using System;
class StudentsGradeCalculator{
	static void Main(string[] args){
		Console.WriteLine("Please enter the number of students: ");
		int studentsCount = int.Parse(Console.ReadLine());

		double[] physicsMarks = new double[studentsCount];
		double[] chemistryMarks = new double[studentsCount];
		double[] mathsMarks = new double[studentsCount];
		double[] percentages = new double[studentsCount];
		char[] grades = new char[studentsCount];

		// Taking input of the marks
		for(int i = 0; i < studentsCount; i++){
			Console.WriteLine("Please enter the marks of student " + (i+1) + " in Physics, Chemistry & Maths, respectively: ");
			physicsMarks[i] = double.Parse(Console.ReadLine());
			chemistryMarks[i] = double.Parse(Console.ReadLine());
			mathsMarks[i] = double.Parse(Console.ReadLine());
			percentages[i] = (physicsMarks[i] + chemistryMarks[i] + mathsMarks[i])/300 * 100;

			// Evaluating grade
			if(percentages[i] >= 80){
				grades[i] = 'A';
			}
			else if(percentages[i] >= 70 && percentages[i] <= 79){
				grades[i] = 'B';
			}
			else if(percentages[i] >= 60 && percentages[i] <= 69){
				grades[i] = 'C';
			}
			else if(percentages[i] >= 50 && percentages[i] <= 59){
				grades[i] = 'D';
			}
			else if(percentages[i] >= 40 && percentages[i] <= 49){
				grades[i] = 'E';
			}
			else{
				grades[i] = 'R';
			}
		}

		// Displaying the results
		for(int i = 0; i < studentsCount; i++){
			Console.WriteLine("Results of student " + (i+1) + " are as follows: ");
			Console.WriteLine("\tMarks in Physics: " + physicsMarks[i]);
			Console.WriteLine("\tMarks in Chemistry: " + chemistryMarks[i]);
			Console.WriteLine("\tMarks in Maths: " + mathsMarks[i]);
			Console.WriteLine("\tPercentage: " + percentages[i]);
			Console.WriteLine("\tGrade: " + grades[i]);
		}
	}
}
