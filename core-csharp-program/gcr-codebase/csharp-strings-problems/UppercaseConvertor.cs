using System;
class UppercaseConvertor{
	static void Main(string[] args){
		Console.WriteLine("Please enter a lowercase string: ");
		string str = Console.ReadLine();
		Console.WriteLine("Uppercase string generated with UppercaseGenerator method: " + UppercaseGenerator(str));
		Console.WriteLine("Uppercase string generated with ToUpper() method: " + str.ToUpper());
	}

	static string UppercaseGenerator(string str){
		string uppercaseString = "";
		foreach (char c in str){
			if(c >= 'a' && c <= 'z'){
				uppercaseString += (char)(c-32);
			}
			else{
				uppercaseString += c;
			}
		}
		return uppercaseString;
	}
}
