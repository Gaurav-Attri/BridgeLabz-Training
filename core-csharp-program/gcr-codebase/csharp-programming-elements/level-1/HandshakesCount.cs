using System;
class HandshakesCount{
	static void Main(String[] args){
		Console.WriteLine("Please enter the total number of students: ");
		int numberOfStudents = int.Parse(Console.ReadLine());
		int maximumHandshakes = (numberOfStudents*(numberOfStudents-1))/2;
		Console.WriteLine("The maximum number of handshakes is: " + maximumHandshakes);
	}
}
