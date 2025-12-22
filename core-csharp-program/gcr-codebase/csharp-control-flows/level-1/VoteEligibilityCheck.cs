using System;
class VoteEligibilityCheck{
	static void Main(string[] args){
		Console.WriteLine("Please enter your age: ");
		int age = int.Parse(Console.ReadLine());
		if(age >= 18){
			Console.WriteLine("The person's age is " + age + " and can vote");
		}
		else{
			Console.WriteLine("The person's age is " + age + " and cannot vote");
		}
	}
}
