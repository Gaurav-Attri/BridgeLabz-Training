using System;
class SplitString{
	static void Main(string[] args){
		Console.WriteLine("Please enter a string: ");
		string str = Console.ReadLine();
		string[,] wordsAndLengths = new string[CountWords(str),2];
		StringBreaker(str, wordsAndLengths);
		CountLengths(wordsAndLengths);

		for(int i = 0; i < wordsAndLengths.GetLength(0); i++){
			Console.WriteLine(wordsAndLengths[i, 0] + " " + wordsAndLengths[i, 1]);
		}
	}

	static void StringBreaker(string str, string[,] wordsAndLengths){
		string word = "";
		int wordIndex = 0;
		for(int i = 0; i < str.Length; i++){
			// if current character is a space, we have found a word
			if(str[i] == ' '){
				wordsAndLengths[wordIndex++, 0] = word;
				word = "";
			}
			// Otherwise we're still creating the word
			else{
				word += str[i];
			}
		}
		// We still have a word which is not present in the 2D array
		if(word.Length != 0){
			wordsAndLengths[wordIndex, 0] = word;
		}

	}

	static void CountLengths(string[,] wordsAndLengths){
		for(int i = 0; i < wordsAndLengths.GetLength(0); i++){
			wordsAndLengths[i, 1] = (wordsAndLengths[i, 0].Length).ToString();
		}
	}

	static int CountWords(string str){
		int wordsCount = 0;
		foreach (char c in str){
			if(c == ' ') wordsCount++;
		}
		return wordsCount+1;
	}
}
