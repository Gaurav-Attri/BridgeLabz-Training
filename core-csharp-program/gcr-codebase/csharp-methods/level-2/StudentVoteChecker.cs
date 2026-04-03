using System;
class StudentVoteChecker{
	static void Main(string[] args){
		int[] studentsAge = new int[10];
		for(int i = 0; i < 10; i++){
			Console.Write("Please enter age of student " + (i+1) + ": ");
			studentsAge[i] = int.Parse(Console.ReadLine());
		}

		for(int i = 0; i < 10; i++){
			if(CanVote(studentsAge[i])) Console.WriteLine("Student " + (i+1) + " can vote");
			else Console.WriteLine("Student " + (i+1) +" cannot vote");
		}
	}

	static bool CanVote(int age){
		return age >= 18;
	}
}
