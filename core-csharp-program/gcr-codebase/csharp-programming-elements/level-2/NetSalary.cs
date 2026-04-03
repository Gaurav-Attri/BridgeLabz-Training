using System;
class NetSalary{
	static void Main(String[] args){
		Console.WriteLine("Please enter your salary: ");
		double salary = double.Parse(Console.ReadLine());
		Console.WriteLine("Please enter your bonus: ");
		double bonus = double.Parse(Console.ReadLine());
		double netSalary = salary + bonus;
		Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + netSalary);
	}
}
