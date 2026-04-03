using System;
class IndexOutOfRangeExceptionArrayDemo{
	static void Main(string[] args){
		int[] arr = {1, 2, 3};
		try{
			Console.WriteLine("arr[3]: " + arr[3]);
		}
		catch(IndexOutOfRangeException ex){
			Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
		}
	}
}
