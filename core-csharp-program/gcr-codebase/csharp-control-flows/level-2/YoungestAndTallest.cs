using System;
class YoungestAndTallest{
	static void Main(string[] args){
		Console.WriteLine("Please enter the ages of the three friends: Amar, Akbar & Anthony, respectively: ");
		int amarAge = int.Parse(Console.ReadLine());
		int akbarAge = int.Parse(Console.ReadLine());
		int anthonyAge = int.Parse(Console.ReadLine());

		Console.WriteLine("Please enter the heights (in cm) of the three friends: Amar, Akbar & Anthony, respectively: ");
		int amarHeight = int.Parse(Console.ReadLine());
		int akbarHeight = int.Parse(Console.ReadLine());
		int anthonyHeight = int.Parse(Console.ReadLine());

		// Finding who is the youngest
		if(amarAge < akbarAge && amarAge < anthonyAge){
			Console.WriteLine("Amar is the youngest");
		}
		else if(akbarAge < amarAge && akbarAge < anthonyAge){
			Console.WriteLine("Akbar is the youngest");
		}
		else{
			Console.WriteLine("Anthony is the youngest");
		}

		// Finding who is the tallest
		if(amarHeight > akbarHeight && amarHeight > anthonyHeight){
			Console.WriteLine("Amar is the tallest");
		}
		else if(akbarHeight > amarHeight && akbarHeight > anthonyHeight){
			Console.WriteLine("Akbar is the tallest");
		}
		else{
			Console.WriteLine("Anthony is the tallest");
		}
	}
}
