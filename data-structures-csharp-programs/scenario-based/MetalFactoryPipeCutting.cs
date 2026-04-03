using System;
class MetalFactoryPipeCutting{
	private static int RodLength = 8;
	private static int[] prices;
	private static int optimalCuttingPrice;
	private static string optimalCuttingSequence;
	private static int customCuttingPrice;
	private static string customCuttingSequence;

	static MetalFactoryPipeCutting(){
		prices = new int[] {0, 2, 4, 3, 3, 8, 1, 7, 4};
	}

	static void Main(string[] args){
		MetalFactoryPipeCutting metalFactoryPipeCutting = new MetalFactoryPipeCutting();
		metalFactoryPipeCutting.StartApplication();
	}

	void StartApplication(){
		Console.WriteLine("\n======== METAL FACTORY PIPE CUTTING ========\n");
		int userChoice;
		do{
			Console.WriteLine("\n======== METAL FACTORY PIPE CUTTING ========\n");
                	Console.WriteLine("1. Cut rod according to the most optimal cut sequence");
                	Console.WriteLine("2. Cut rod according to the user given sequence");
                	Console.WriteLine("3. Compare the result of 1 and 2");
			Console.WriteLine("0. Exit");
                	Console.Write("Enter your choice: ");
                	userChoice = int.Parse(Console.ReadLine());

			switch(userChoice){
				case 1:
					FindMostOptimalCutting();
					break;
				case 2:
					FindCustomCutting();
					break;
				case 3:
					FindMostOptimalCutting();
					FindCustomCutting();
					CompareResults();
					break;
			}

		}while(userChoice != 0);
				
	}

	void FindMostOptimalCutting(){
		optimalCuttingPrice = 0;
		optimalCuttingSequence = "";

		FindOptimalRecursively(RodLength, 0, "");

		Console.WriteLine("\nMost optimal cutting:");
		Console.WriteLine("Cut Sequence: " + optimalCuttingSequence);
		Console.WriteLine("Total Price: " + optimalCuttingPrice);
	}

	void FindOptimalRecursively(int remainingLength, int currentPrice, string currentSequence){
		if(remainingLength == 0){
			if(currentPrice > optimalCuttingPrice){
				optimalCuttingPrice = currentPrice;
				optimalCuttingSequence = currentSequence;
			}
			return;
		}

		for(int cut = 1; cut <= remainingLength; cut++){
			FindOptimalRecursively(remainingLength - cut, currentPrice + prices[cut], currentSequence + cut);
		}
	}

	void FindCustomCutting(){
		Console.WriteLine("\nPlease enter custom cutting order as 2134: ");
		customCuttingSequence = Console.ReadLine();

		customCuttingPrice = 0;
		int totalLength = 0;

		foreach(char c in customCuttingSequence){
			int cut = c - '0';
			totalLength += cut;
			customCuttingPrice += prices[cut];
		}	

		if(totalLength != RodLength){
			Console.WriteLine("\nInvalid Cutting Sequence. Length Mismatch!");
			customCuttingPrice = 0;
			return;
		}

		Console.WriteLine("\nCustom Cutting: ");
		Console.WriteLine("Cut Sequence: " + customCuttingSequence);
		Console.WriteLine("Total Price: " + customCuttingPrice);
	}

	void CompareResults(){
		Console.WriteLine("\n==== COMPARISION RESULTS ====\n");
		Console.WriteLine("Optimal Price: " + optimalCuttingPrice);
		Console.WriteLine("Custom Price: " + customCuttingPrice);

		if(customCuttingPrice > optimalCuttingPrice){
			Console.WriteLine("Custom cutting beats optimal.");
		}
		else if(customCuttingPrice < optimalCuttingPrice){
			Console.WriteLine("Custom cutting is not optimal");
		}
		else{
			Console.WriteLine("Custom cutting is optimal");
		}
	}

}
