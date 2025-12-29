using System;
class ParagraphAnalyzer{
	static void Main(string[] args){
		StartApplication();
	}

	static void StartApplication(){
		DisplayMenu();
		int userChoice = TakeUserInput();
		
		Console.WriteLine("\nPlease enter a properly formatted string: \n");
		string paragraph = Console.ReadLine();
		
		// If the input string is invalid then the program exits with code 1
		if(CheckEdgeCases(paragraph)){
			Console.WriteLine("\nExiting the program.....");
			Environment.Exit(1);
		}

		string[] words = SplitSentence(paragraph);
		
		switch(userChoice){
			case 1:
				Console.WriteLine("The number of words in the given paragraph is: " + CountWords(paragraph));
				break;
			case 2:
				Console.WriteLine("The longest word in the given paragraph is: " + FindLongestWord(words));
				break;
			case 3:
				Console.Write("\nPlease enter the word to be replaced: ");
				string wordToReplace = Console.ReadLine();
				Console.Write("\nPlease enter the word to replace " + wordToReplace + " with: ");
				string wordToReplaceWith = Console.ReadLine();
				Console.WriteLine("\nHere is your paragraph after replacing all occurrences of \"" + wordToReplace + "\" with \"" + wordToReplaceWith + "\"\n");
				Console.WriteLine(ReplaceWords(words, wordToReplace, wordToReplaceWith));
				break;
		}
		
	}

	// Method to display the menu
	static void DisplayMenu(){
		Console.WriteLine("\n===============PARAGRAPH ANALYZER===============\n");
		Console.WriteLine("1. Count the number of words in the Paragraph");
		Console.WriteLine("2. Find and display the longest word");
		Console.WriteLine("3. Replace all occurrences of a specific word with another word (case-insensitive)");
	}

	// Method to take user input
	static int TakeUserInput(){
		Console.Write("\nPlease enter your choice: ");
		int userChoice = int.Parse(Console.ReadLine());
		return userChoice;
	}

	// Method to split the sentence in words
	static string[] SplitSentence(string paragraph){
		string[] words = new string[CountWords(paragraph)];
		int index = 0;
		string word = "";
		foreach (char c in paragraph){
			if(c == ' '){
				words[index++] = word;
				word = "";
			}
			else{
				word += c;
			}	
		}
		if(word.Length != 0){
			words[index] = word;
		}

		return words;
	}

	// Method to count the number of words
	static int CountWords(string paragraph){
		int wordsCount = 0;
		for(int i = 0; i < paragraph.Length; i++){
			if(paragraph[i] == ' ') wordsCount++;
		}
		return wordsCount+1;
	}

	// Method to find the longest word in the sentence
	static string FindLongestWord(string[] words){
		string longestWord = ""; // Initially we consider "" to be the longest word
		foreach (string word in words){
			if(word.Length > longestWord.Length) longestWord = word;
		}
		return longestWord;
	}

	// Method to replace all occurrence of a word with another word
	static string ReplaceWords(string[] words, string wordToReplace, string wordToReplaceWith){
		string result = "";
		for(int i = 0; i < words.Length; i++){
			if(words[i] == wordToReplace){
				result += wordToReplaceWith;
			}
			else{
				result += words[i];
			}
			if(i != words.Length -1) result += ' ';
		}
		return result;
	}

	// Method to check for edge cases
	// This method returns true if the string is empty or contains only spaces and false otherwise
	static bool CheckEdgeCases(string paragraph){
		if(paragraph.Length == 0){
			Console.WriteLine("\nYou entered empty string. Please enter a string with some characters");
			return true;
		}
		if(CheckAllSpaces(paragraph)){
			Console.WriteLine("\nYour string contains only spaces. Please enter a valid string.");
			return true;
		}
		return false;
		
	}

	// Method to check if the string contains all spaces
	static bool CheckAllSpaces(string paragraph){
		bool IsAllSpace = true; // Initially considering that the string is all spaces
		foreach (char c in paragraph){
			if(c != ' '){
				IsAllSpace = false;
				break;
			}
		}
		return IsAllSpace;
	}
}
