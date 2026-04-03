using System;
class MostFrequentChar{
	static void Main(string[] args){
		// Accepting only lowercase strings
		string str;
		while(true){
			Console.WriteLine("Please enter a string (lowercase only): ");
			str = Console.ReadLine();
			bool isStringLowercase = true; // Intially we consider the string is lowercase
			foreach (char c in str){
				if(!Char.IsLower(c)){
					isStringLowercase = false;
					break;
				}
			}
			if(!isStringLowercase){
				Console.WriteLine("Please enter a lowercase string only");
			}
			else{
				break;
			}
		}
		Console.WriteLine("The most frequent character in " + str + " is " + MostFrequentCharacter(str));
	}

	static char MostFrequentCharacter(string str){
		// Creating a frequency array
		int[] freq = new int[26];
		int highestFreq = 0;
		char mostFreqChar = 'a'; // Initially considering a to be the most frequent character
		foreach(char c in str){
			freq[c-'a']++;
		}

		for(int i = 0; i < 26; i++){
			if(freq[i] > highestFreq){
				highestFreq = freq[i];
				mostFreqChar = (char)('a' + i);
			}
		}

		return mostFreqChar;
	}
}
