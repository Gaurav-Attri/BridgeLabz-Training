using System;
class RemoveSpecificChar{
	static void Main(string[] args){
		Console.WriteLine("Please enter a string: ");
		string str = Console.ReadLine();
		Console.WriteLine("Please enter the character to remove: ");
		char charToRemove = (char)(Console.Read());
		Console.WriteLine(str + " after removing all " + charToRemove + "'s from it: " + RemoveChar(str, charToRemove));
	}

	static string RemoveChar(string str, char charToRemove){
		string result = "";

		foreach(char c in str){
			if(!(c == charToRemove)){
				result += c;
			}
		}

		return result;
	}
}
