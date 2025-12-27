using System;
class ToggleCharCase{
	static void Main(string[] args){
		Console.WriteLine("Please enter a string: ");
		string str = Console.ReadLine();
		Console.WriteLine(str + " after toggling case looks like " + ToggleCase(str));
	}

	static string ToggleCase(string str){
		string toggledString = "";

		foreach(char c in str){
			if(c >= 'a' && c <= 'z'){
				toggledString += (char)(c-32);
			}
			else if(c >= 'A' && c <= 'Z'){
				toggledString += (char)(c+32);
			}
			// If it is neither a lowercase nor an uppercase letter
			else{
				toggledString += c;
			}
		}
		return toggledString;
	}
}
