using System;
class LexographicalComparison{
	static void Main(string[] args){
		Console.WriteLine("Please enter the first string: ");
		string str1 = Console.ReadLine();
		Console.WriteLine("Please enter the second string: ");
		string str2 = Console.ReadLine();
			

		int comparisonResult = CompareStrings(str1, str2);
		if(comparisonResult == 1){
			Console.WriteLine("\"" + str1 + "\" comes before \"" + str2 + "\" in lexographical order");
		}
		else if(comparisonResult == -1){	
			Console.WriteLine("\"" + str2 + "\" comes before \"" + str1 + "\" in lexographical order");
		}
		else{			
			Console.WriteLine("\"" + str1 + "\" equals \"" + str2 + "\" in lexographical order");
		}

	}

	// CompareString return 1 if str1 < str2, -1 if str2 < str1 & 0 if str1 == str2
	static int CompareStrings(string str1, string str2){
		// Converting str1 and str2 to lowercase to make the program Case insensitive
		str1 = str1.ToLower();
		str2 = str2.ToLower();

		int str1Pointer = 0;
		int str2Pointer = 0;

		while(str1Pointer < str1.Length || str2Pointer < str2.Length){
			if(str1Pointer >= str1.Length || str1[str1Pointer] < str2[str2Pointer]){
				// If str1Pointer exceeds str1 this means str2.Length > str1.Length and first
				// str2.Length-str1.Length characters in both the strings are equal which 
				// makes str1 lexographically smaller
				return 1;
			}
			if(str2Pointer >= str2.Length || str2[str2Pointer] < str1[str1Pointer]){
				// If str2Pointer exceeds str2 this means str1.Length > str2.Length and first
				// str1.Length-str2.Length characters in both the strings are equal which
				// makes str2 lexographically smaller
				return -1;
			}
			str1Pointer++;
			str2Pointer++;
		}

		return 0;
	}
}
