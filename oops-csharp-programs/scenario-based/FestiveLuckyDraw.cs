using System;
class FestiveLuckyDraw{
	private string visitorName;
	private int visitorCount;

	static void Main(string[] args){
		FestiveLuckyDraw festiveLuckyDraw = new FestiveLuckyDraw();
		festiveLuckyDraw.StartApplication();
	}

	private void StartApplication(){
		Console.WriteLine("\n ========== WELCOME TO DIWALI FESTIVAL LUCKY DRAW ==========\n");
		Console.Write("Please enter the number of visitors: ");
		this.visitorCount = int.Parse(Console.ReadLine());

		// Asking visitors for the lucky draw
		for(int i = 0; i < this.visitorCount; i++){
			Console.Write("Please enter your name: ");
			this.visitorName = Console.ReadLine();
			Console.WriteLine("\nPress any key to draw your number.....");
			Console.ReadKey();

			int drawnNumber = new Random().Next(1, 1000);
			Console.WriteLine("Your number: " + drawnNumber);
			if(drawnNumber%3 == 0 && drawnNumber%5 == 0){
				UserWon();
			}
			else{
				UserLost();
			}

		}
	}

	private void UserWon(){
		Console.WriteLine(this.visitorName + " you won the gift!");
	}

	private void UserLost(){
		Console.WriteLine(this.visitorName + " you didn't win the gift. Try Again next time!");
	}
}
