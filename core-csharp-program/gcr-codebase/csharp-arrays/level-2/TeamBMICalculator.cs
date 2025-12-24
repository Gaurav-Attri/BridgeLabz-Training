using System;
class TeamBMICalculator{
	static void Main(string[] args){
		Console.WriteLine("Please enter the number of team members: ");
		int teamMembersCount = int.Parse(Console.ReadLine());
		double[,] teamMembersData = new double[teamMembersCount,3]; // data is stored as [weight, height, BMI]
		string[] weightStatus = new string[teamMembersCount];

		for(int i = 0; i < teamMembersCount; i++){
			Console.WriteLine("Please enter the weight (in kg) and height of person (in cm) " + (i+1));
			double weight = double.Parse(Console.ReadLine());
			double height = double.Parse(Console.ReadLine())*0.01;
			double BMI = weight/(height*height);
			teamMembersData[i, 0] = weight;
			teamMembersData[i, 1] = height;
			teamMembersData[i, 2] = BMI;

			if(BMI <= 18.4){
				weightStatus[i] = "Underweight";
			}
			else if(BMI >= 18.5 && BMI <= 24.9){
				weightStatus[i] = "Normal";
			}
			else if(BMI >= 25.0 && BMI <= 39.9){
				weightStatus[i] = "Overweight";
			}
			else if(BMI >= 40.0){
				weightStatus[i] = "Obese";
			}
		}

		// Displaying the result
		for(int i = 0; i < teamMembersCount; i++){
			Console.WriteLine("Person " + (i+1) + "'s weight is " + teamMembersData[i, 0] + " kg height is " + teamMembersData[i, 1] + " m BMI is " + teamMembersData[i, 2] + " and weight status is " + weightStatus[i]);
		}
	}
}
