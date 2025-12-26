using System;
class StringCharArray{
	static void Main(string[] args){
		Console.WriteLine("Please enter a string: ");
		string str = Console.ReadLine();
		char[] strCharArr1 = GenerateCharArray(str);
		char[] strCharArr2 = str.ToCharArray();
		Console.WriteLine("Character array generated with GenerateCharArray method: ");
		foreach (char c in strCharArr1){
			Console.Write(c + " ");
		}
		Console.WriteLine();

		Console.WriteLine("Character array generated with ToCharArray method: ");
		foreach (char c in strCharArr2){
			Console.Write(c + " ");
		}
	}

	static char[] GenerateCharArray(string str){
		char[] stringChars = new char[str.Length];
		for(int i = 0; i < str.Length; i++){
			stringChars[i] = str[i];
		}
		return stringChars;
	}
}
