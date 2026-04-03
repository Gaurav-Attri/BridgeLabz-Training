using System;
class SubstringGenerator{
	static void Main(string[] args){
		Console.WriteLine("Please enter the string: ");
		string str = Console.ReadLine();
		Console.WriteLine("Please enter the starting index of the substring (inclusive): ");
		int startIndex = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter the ending index of the substring (exclusive): ");
		int endIndex = int.Parse(Console.ReadLine());
		Console.WriteLine("Substring generated with GenerateSubstring method: " + GenerateSubstring(str, startIndex, endIndex));
		Console.WriteLine("Substring generated with Substring method: " + str.Substring(startIndex, endIndex));
	}

	static string GenerateSubstring(string str, int startIndex, int endIndex){
		string substring = "";
		// To make sure endIndex is not greater than string's length, we've used two conditions in the loop
		for(int i = startIndex; i < endIndex && i < str.Length; i++){
			substring += str[i];
		}
		return substring;
	}
}
