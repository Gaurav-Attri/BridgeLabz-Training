using System;
class IndexOutOfRangeExceptionDemo{
	static void Main(string[] args){
		string str = "string";
		try{
			Console.WriteLine("Character at index 6 is: " + str[6]);
		}
		catch(IndexOutOfRangeException ex){
			Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
		}
	}
}
