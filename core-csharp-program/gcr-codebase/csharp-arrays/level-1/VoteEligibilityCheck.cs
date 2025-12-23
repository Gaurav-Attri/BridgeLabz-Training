using System;
class VoteEligibilityCheck{
	static void Main(string[] args){
		int[] ages = new int[10];
		Console.WriteLine("Please enter the ages of 10 students: ");
		for(int i = 0; i < 10; i++){
			ages[i] = int.Parse(Console.ReadLine());
		}
		for(int i = 0; i < 10; i++){
			if(ages[i] < 0){
				Console.WriteLine("Invalid Age");
			}
			else if(ages[i] < 18){
				Console.WriteLine("The student with age " + ages[i] + " cannot vote.");
			}
			else{
				Console.WriteLine("The student with age " + ages[i] + " can vote.");
			}
		}
	}
}
