using System;
class NullReferenceExceptionDemo{
	static void Main(string[] args){
		string nullString = null;
		try{
			Console.WriteLine("Length of the nullString string is: " + nullString.Length);
		}
		catch(NullReferenceException ex){
			Console.WriteLine("NullReferenceException: " + ex.Message);
		}
	}
}
