using System;
class VowelsAndConsonantsCount{
	static void Main(string[] args){
		Console.WriteLine("Please enter a string: ");
		string str = Console.ReadLine();
		Console.WriteLine("Number of vowels in the string: " + CountVowels(str));
		Console.WriteLine("Number of consonants in the string: " + CountConsonants(str));
	}

	static int CountVowels(string str){
		int count = 0;
		foreach (char c in str.ToLower()){
			if(isVowel(c)) count++;
		}
		return count;
	}

	static int CountConsonants(string str){
		int count = 0;
		foreach (char c in str.ToLower()){
			if(!isVowel(c)) count++;
		}
		return count;
	}

	static bool isVowel(char ch){
		int[] vowels = {'a', 'e', 'i', 'o', 'u'};
		foreach (char c in vowels){
			if(c == ch) return true;
		}
		return false;
	}
}
