using System;
public class StudentScoreManager{
	private double[] studentScores;
	private string[] studentNames;
	private int numberOfStudents;

	public static void Main(string[] args){
		StudentScoreManager driver = new StudentScoreManager();
		driver.StartApplication();
	}

	private void StartApplication(){
		TakeInput();
		DisplayMenu();
	}
	
	// Method to show menu to the user and handle user choice
	private void DisplayMenu(){
		Console.WriteLine("=================================================");
		Console.WriteLine("\n1. Display the average score of the students.");
		Console.WriteLine("2. Display the highest and lowest scores and scorers.");
		Console.WriteLine("3. Display the above average scores and scorers.\n");
		Console.Write("Please enter your choice (1, 2 or 3): ");
		int userChoice = int.Parse(Console.ReadLine());
		Console.WriteLine("=================================================");

		switch(userChoice){
			case 1:
				double averageScore = GetAverageScore();
				Console.WriteLine("\nAverage score of the students is: " + averageScore + "\n");
				break;
			case 2:
				DisplayHighestAndLowestScores();
				break;
			case 3:
				DisplayAboveAvgScores();
				break;
		}
	}

	// Method to take student data input from the user.
	private void TakeInput(){
		Console.WriteLine("\n=============== STUDENT SCORE MANAGER ===============\n");
		Console.Write("Please enter the number of students: ");
		numberOfStudents = int.Parse(Console.ReadLine());
		studentScores = new double[numberOfStudents];
		studentNames = new string[numberOfStudents];
		
		for(int i = 0; i < numberOfStudents; i++){
			Console.Write("\nPlease enter the name of the student number " + (i+1) + ": ");
			studentNames[i] = Console.ReadLine();
			Console.Write("Please enter the score of the student number " + (i+1) + ": ");
			
			// Handling negative and non-numeric inputs for score.
			try{
				studentScores[i] = int.Parse(Console.ReadLine());
				if(studentScores[i] <= 0){
					Console.WriteLine("\nPlease insert a positive value for score.\n");
					i--;
				}
			}
			catch(FormatException){
				Console.WriteLine("\nPlease insert a numeric value for score.\n");
				i--;
			}
		}
	}

	// Method to display lower and heighest scores and scorers
	private void DisplayHighestAndLowestScores(){
		double lowestScore = studentScores[0];
		double highestScore = studentScores[0];
		int lowestScoreIndex = 0;
		int highestScoreIndex = 0;

		for(int i = 1; i < numberOfStudents; i++){
			if(studentScores[i] < lowestScore){
				lowestScore = studentScores[i];
				lowestScoreIndex = i;
			}
			if(studentScores[i] > lowestScore){
				highestScore = studentScores[i];
				highestScoreIndex = i;
			}
		}

		Console.WriteLine("Student with the heighest score: " + studentNames[highestScoreIndex] + " has a score of: " + studentScores[highestScoreIndex]);
		Console.WriteLine("Student with the lowest score: " + studentNames[lowestScoreIndex] + " has a score of: " + studentScores[lowestScoreIndex]);
	}

	// Method to display above average scores and scorers
	private void DisplayAboveAvgScores(){
		double averageScore = GetAverageScore();
		Console.WriteLine("Following are the students with above average scores: \n");
		for(int i = 0; i < numberOfStudents; i++){
			if(studentScores[i] > averageScore){
				Console.WriteLine("Student Name: " + studentNames[i] + "\t|\tStudent Score: " + studentScores[i]);
			}
		}
	}

	// Method to calculate and return average score
	private double GetAverageScore(){
		double scoreSum = 0;
		double averageScore;
		foreach (double studentScore in studentScores){
			scoreSum += studentScore;
		}
		averageScore = scoreSum/numberOfStudents;
		return averageScore;
	}
}
