using System;
public class TemperatureAnalyzer{
	/*
	 * temperatureArray is a 2D array that represents the temperature of 7 days with 24 hours temperature
	 * for each day
	 * averageTemperatureDay array holds the average temperature of each day
	 */
	private static int numberOfDays = 7;
	private static int numberOfHours = 24;
	private static float[,] temperatureArray = new float[numberOfDays, numberOfHours];
	private static float[] averageTemperaturePerDay;
	private static string[] dayNames = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

	public static void Main(string[] args){
		StartApplication();		
	}

	// Method to start the application
	private static void StartApplication(){
		// As soon as the application starts, it fills the temperatureArray with random float temperature values
		FillTemperatureArray();

		int userChoice = DisplayMenuAndTakeUserInput();
		averageTemperaturePerDay = FindAverageTemperaturePerDay();
		
		switch(userChoice){
			case 1:
				DisplayHottestAndColdestTemperatureEachDay();
				break;
			case 2:
				DisplayAverageTemperaturePerDay();
				break;
		}
	}

	// Method to display the average temperature per day
	private static void DisplayAverageTemperaturePerDay(){
		Console.WriteLine("\nGiven below is the average temperature per day:\n");
		
		for(int i = 0; i < averageTemperaturePerDay.Length; i++){
			Console.WriteLine(dayNames[i] + "'s Average Temperature: " + averageTemperaturePerDay[i]);
		}
	}

	// Method to display the hottest and coldest temperature for each day and display them
	private static void DisplayHottestAndColdestTemperatureEachDay(){
		Console.WriteLine("\nGiven below are the hottest and coldest temperatures each day");
		for(int i = 0; i < numberOfDays; i++){
			float hottestTemperatureToday = float.MinValue;
			float coldestTemperatureToday = float.MaxValue;

			for(int j = 0; j < numberOfHours; j++){
				if(temperatureArray[i, j] > hottestTemperatureToday){
					hottestTemperatureToday = temperatureArray[i, j];
				}
				if(temperatureArray[i, j] < coldestTemperatureToday){
					coldestTemperatureToday = temperatureArray[i, j];
				}
			}

			Console.WriteLine("Hottest Temperature on " + dayNames[i] + " " + hottestTemperatureToday + " degree Celsius");
			Console.WriteLine("Coldest Temperature on " + dayNames[i] + " " + coldestTemperatureToday + " degree Celsius");
			Console.WriteLine();
		}
	}


	// Method to find average temperature per day and return the average temperature array
	private static float[] FindAverageTemperaturePerDay(){
		float[] averageTemperaturePerDay = new float[numberOfDays];

		for(int i = 0; i < numberOfDays; i++){
			float temperatureSum = 0;
			for(int j = 0; j < numberOfHours; j++){
				temperatureSum += temperatureArray[i, j];
			}
			averageTemperaturePerDay[i] = temperatureSum/numberOfHours;
		}
		return averageTemperaturePerDay;
	}

	// Method to display the menu and accept user's choice
	private static int DisplayMenuAndTakeUserInput(){
		Console.WriteLine("\n=============== TEMPERATURE ANALYZER ===============\n");
		Console.WriteLine("1. Find the hottest and coldest days.");
		Console.WriteLine("2. Find the average temperature per day.");
		Console.Write("\nPlease enter your choice (1 or 2): ");
		int userChoice = int.Parse(Console.ReadLine());
		return userChoice;
	}

	// Method to fill the temperatureArray with random float temperature values
	private static void FillTemperatureArray(){
		float minHourlyTemperature = 10; // Minimum temperature for any hour is 10 degree celsius
		float maxHourlyTemperature = 50; // Maximum temperature for any hour is 50 degree celsius
		Random random = new Random();
		// Traversing through the temperatureArray to fill it with random float values
		for(int i = 0; i < temperatureArray.GetLength(0); i++){
			for(int j = 0; j < temperatureArray.GetLength(1); j++){
				// Calculating random hourly temperature with the following formula
				// temperature = randomValue * (maxTemperature - minTemperature) + minTemperature
				float hourlyTemperature = (float)(random.NextDouble()*(maxHourlyTemperature-minHourlyTemperature) + minHourlyTemperature);
				// assigning the random temperature to the (i, j)th cell in the temperatureArray
				temperatureArray[i, j] = hourlyTemperature;
			}
		}
	}
}
