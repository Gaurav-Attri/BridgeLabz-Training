using System;
class ReplaceWord{
	static void Main(string[] args){
		Console.WriteLine("Please enter the sentence: ");
		string sentence = Console.ReadLine();
		Console.WriteLine("Please enter the word to replace: ");
		string wordToReplace = Console.ReadLine();
		Console.WriteLine("Please enter the word to replace with: ");
		string wordToReplaceWith = Console.ReadLine();
		Console.WriteLine("After replacing, this is what the sentence looks like: " + ReplaceWords(sentence, wordToReplace, wordToReplaceWith));
	}

	static string ReplaceWords(string sentence, string wordToReplace, string wordToReplaceWith){
		string[] words = sentence.Split(' ');
		for(int i = 0; i < words.Length; i++){
			if(words[i].Equals(wordToReplace)){
				words[i] = wordToReplaceWith;
			}
		}
		string resultString = String.Join(" ", words);
		return resultString;
	}
}
