using System;
class CheckAnagrams{
	static void Main(string[] args){
		Console.WriteLine("Please enter the first string: ");
		string str1 = Console.ReadLine();
		Console.WriteLine("Please enter the second string: ");
		string str2 = Console.ReadLine();
		Console.WriteLine("Are the two string " + str1 + " and " + str2 + " anagrams? " + AreAnagrams(str1, str2));
	}

	static bool AreAnagrams(string str1, string str2){
		// If the two strings are not equal then they aren't anagrams;
		if(str1.Length != str2.Length) return false;

		// Freq arr for str1
		int[] freq1 = new int[26];

		// Freq arr for str2
		int[] freq2 = new int[26];

		for(int i = 0; i < str1.Length; i++){
			freq1[str1[i]-'a']++;
			freq2[str2[i]-'a']++;
		}

		for(int i = 0; i < 26; i++){
			if(freq1[i] != freq2[i]) return false;
		}

		return true;
	}
}
