using System;
class SentenceFormatter{
	static void Main(String[] args){
		StartApplication();
	}

	// Method to start the application
	static void StartApplication(){
		string paragraph = TakeUserInput();
		string temp = paragraph;
		paragraph = RemoveExtraSpaces(paragraph);
		paragraph = AddSpaceAfterPunctuation(paragraph);
		paragraph = CapitalizePara(paragraph);
		Console.WriteLine(paragraph);
		
	}
	
	// Method to take user input
	static string TakeUserInput(){
		Console.WriteLine("\n===============STRING FORMATTER===============\n");
		Console.WriteLine("Please enter a paragraph (hit \"Enter\" key after you're done): \n");
		string paragraph = Console.ReadLine();
		return paragraph;
	}

	// Method to remove extra spaces from start, end and the middle
	static string RemoveExtraSpaces(string paragraph){
		string result = "";
		for(int i = 0; i < paragraph.Length; i++){
			if(paragraph[i] == ' '){
				// If the current character is space and the next character is a punctuation
				// then we don't add any space in the result string. 
				if(i < paragraph.Length && IsNextPunctuation(paragraph, i)){
					continue;
				}

				// Appending space only if the result string isn't empty and 
				// the last character in the result string isn't a space
				if(result.Length != 0 && result[result.Length-1] != ' '){
					result += ' ';
				}
			}
			else{
				// Appending the non-space characters to the resultant string
				result += paragraph[i];
			}
		}
		return result;
	}

	// Method to capitalize the string
	static string CapitalizePara(string paragraph){
		string result = "";
		for(int i = 0; i < paragraph.Length; i++){
			// If this is the first character of the paragraph
			// And this is not a special character
			// And this is a smallcase letter
			// then we capitalize it
			if(i == 0 && !IsPunctuation(paragraph[0]) && IsLower(paragraph[0])){
				result += (char)(paragraph[i]-32);
			}
			
			// If this is a punctuation mark then we add it as it is in the result
			else if(IsPunctuation(paragraph[i])){
				result += paragraph[i];
			}

			// If this is a letter after punctuation mark and a space, we capitalize it.
			else if(i > 1 && !IsPunctuation(paragraph[i]) && IsLower(paragraph[i]) && IsPunctuation(paragraph[i-2]) && paragraph[i-1] == ' '){
				result += (char)(paragraph[i]-32);
			}
			else{
				result += paragraph[i];
			}
		}
		return result;
	}

	// Adding spaces after punctuation
	static string AddSpaceAfterPunctuation(string paragraph){
		string result = "";
		for(int i = 0; i < paragraph.Length; i++){
			result += paragraph[i];
			if(IsPunctuation(paragraph[i]) && i < paragraph.Length-1 && paragraph[i+1] != ' '){
				result += ' ';
			}
		}
		return result;
	}

	static bool IsPunctuation(char c){
		if(c == '.' || c == ',' || c == '?' || c == '!') return true;
		return false;
	}

	static bool IsLower(char c){
		if(c >= 'a' && c <= 'z') return true;
		return false;
	}

	static bool IsNextPunctuation(string paragraph, int index){
		while(index < paragraph.Length && paragraph[index] == ' ') index++;
		if(index < paragraph.Length) return IsPunctuation(paragraph[index]);
		return false;
	}
}
