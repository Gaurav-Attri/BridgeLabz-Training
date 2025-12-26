using System;
class FormatExceptionDemo{
	static void Main(string[] args){
		Console.WriteLine("Enter a number or enter something else to raise an exception: ");
		try{
			int num = int.Parse(Console.ReadLine());
		}
		catch(FormatException ex){
			Console.WriteLine("FormatException: " + ex.Message);
		}

	}
}
