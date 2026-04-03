using System;
class ArgumentOutOfRangeExceptionDemo{
	static void Main(string[] args){
		string str = "string";
		try{
			Console.WriteLine("Substring is: " + str.Substring(2, 10));
		}
		catch(ArgumentOutOfRangeException ex){
			Console.WriteLine("ArgumentOutOfRangeException: " + ex.Message);
		}
	}
}
