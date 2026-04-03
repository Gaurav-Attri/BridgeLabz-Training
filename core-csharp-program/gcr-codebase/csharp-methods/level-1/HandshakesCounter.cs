using System;
class HandshakesCounter{
	static void Main(string[] args){
		Console.WriteLine("Please enter the number of students: ");
		int studentsCount = int.Parse(Console.ReadLine());
		Console.WriteLine("The maximum number of handshakes among " + studentsCount + " students is: " + CountHandshakes(studentsCount));
	}

	static int CountHandshakes(int studentsCount){
		return (studentsCount*(studentsCount-1))/2;
	}	
}
