using System;
class CountSubstringOccurrences{
	static void Main(string[] args){
		Console.WriteLine("Please enter a string: ");
		string str = Console.ReadLine();
		Console.WriteLine("Please enter the substring to look for: ");
		string substr = Console.ReadLine();
		Console.WriteLine("The number of times that " + substr + " appears in " + str + " is: " + CountOccurrences(str, substr));
	}

	static int CountOccurrences(string str, string substr){
		int substringOccurrenceCount = 0;
		int i = 0;
		while(i < (str.Length - substr.Length)){
			int substrIndex = str.IndexOf(substr, i);
			if(substrIndex != -1){
				substringOccurrenceCount++;
				i = substrIndex + 1;
			}
			else{
				// Breaking away because if we couldn't find the substring now, we can't find
				// it in the future 
				break;  
			}
		}
		return substringOccurrenceCount;
	}
}
