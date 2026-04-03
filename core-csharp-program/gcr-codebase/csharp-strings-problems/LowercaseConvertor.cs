using System;
class LowercaseConvertor{
	static void Main(string[] args){
		Console.WriteLine("Please enter a string: ");
		string str = Console.ReadLine();
		Console.WriteLine("str converted to lowercase with LowercaseGenerator method: " + LowercaseGenerator(str));
		Console.WriteLine("str converted to lowercase with ToLower method: " + str.ToLower());
	}

	static string LowercaseGenerator(string str){
		string lowercaseString = "";
		foreach (char c in str){
			if(c >= 'A' && c <= 'Z'){
				lowercaseString += (char)(c + 32);
			}	
			else{
				lowercaseString += c;
			}
		}
		return lowercaseString;
	}
}
