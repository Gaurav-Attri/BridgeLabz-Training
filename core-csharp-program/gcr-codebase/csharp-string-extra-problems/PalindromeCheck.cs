using System;
class PalindromeCheck{
	static void Main(string[] args){
		Console.WriteLine("Please enter a string: ");
		string str = Console.ReadLine();
		Console.WriteLine("Is " + str + " palindrome? " + IsPalindrome(str));
	}

	static bool IsPalindrome(string str){
		int startPointer = 0, endPointer = str.Length - 1;
		while(startPointer <= endPointer){
			if(str[startPointer] != str[endPointer]) return false;
			startPointer++;
			endPointer--;
		}
		return true;
	}
}
