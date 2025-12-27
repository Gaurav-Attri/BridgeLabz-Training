using System;
class LongestWord{
	static void Main(string[] args){
		Console.WriteLine("Please enter a sentence: ");
		string sentence = Console.ReadLine();
		Console.WriteLine("Longest word in the sentence is: " + FindLongestWord(sentence));
	}

	static string FindLongestWord(string sentence){
		string[] words = sentence.Split(' ');
		string longestWord = words[0];

		foreach (string word in words){
			if(word.Length > longestWord.Length){
				longestWord = word;
			}
		}

		return longestWord;
	}
}
