using System;
class StringComparison{
	static void Main(string[] args){
		Console.WriteLine("Please enter the first string: ");
		string string1 = Console.ReadLine();
		Console.WriteLine("Please enter the second string: ");
		string string2 = Console.ReadLine();
		Console.WriteLine("string1 and string2 compared with CompareStrings method: " + CompareStrings(string1, string2));
		Console.WriteLine("string1 and string2 compared with Equals method: " + string1.Equals(string2));
	}

	static bool CompareStrings(string string1, string string2){
		// If the two strings are not equal in size
		if(string1.Length != string2.Length) return false;

		for(int i = 0; i < string1.Length; i++){
			// If a character at ith index doesn't match
			if(string1[i] != string2[i]) return false;
		}

		return true;
	}
}
