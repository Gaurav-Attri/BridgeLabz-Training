using System;
class DuplicateRemoval{
	static void Main(string[] args){
		Console.WriteLine("Please enter a string: ");
		string str = Console.ReadLine();
		Console.WriteLine("String after removing all the duplicate characters from it: " + RemoveDuplicate(str));
	
	}

	static string RemoveDuplicate(string str){
		string duplicateFreeString = "";
		for(int i = 0; i < str.Length; i++){
			bool duplicateFlag = false; // Initially considering the current char isn't duplicate
			for(int j = 0; j < str.Length; j++){
				if(i != j && str[i] == str[j]){
					duplicateFlag = true; // Marking the current char to be duplicate
					break;
				}
			}
			if(!duplicateFlag) duplicateFreeString += str[i];
		}
		return duplicateFreeString;
	}
}
