using System;
class StringReversal{
	static void Main(string[] args){
		Console.WriteLine("Please enter a string: ");
		string str = Console.ReadLine();
		Console.WriteLine("Reversed string is: " + ReverseString(str));
	}

	static string ReverseString(string str){
		string reversedString = "";
		for(int i = str.Length - 1; i >= 0; i--){
			reversedString += str[i];
		}
		return reversedString;
	}
}
