using System;

class TeamBMICalculator{
    static void Main(string[] args){
        double[,] personData = new double[10, 3];
        Console.WriteLine("Enter weight (kg) and height (cm) for 10 people: ");
        for (int i = 0; i < 10; i++){
            Console.WriteLine("Person " + (i + 1) + ": ");
            Console.Write("Weight (kg): ");
            personData[i, 0] = double.Parse(Console.ReadLine());
            Console.Write("Height (cm): ");
            personData[i, 1] = double.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        // This method fills the personData array with BMI information
        CalculateBMI(personData);

        for (int i = 0; i < 10; i++){
            double bmi = personData[i, 2];
            string status = GetBMIStatus(bmi);

            Console.WriteLine("Results of the person number " + (i+1));
	    Console.WriteLine("Height " + personData[i, 0]);
	    Console.WriteLine("Weight " + personData[i, 1]);
	    Console.WriteLine("BMI " + bmi);
	    Console.WriteLine("BMI Status " + status);
        }
    }

    static void CalculateBMI(double[,] personData){
        for (int i = 0; i < 10; i++)
        {
            double weight = personData[i, 0];
            double heightInCm = personData[i, 1];

            double heightInMeters = heightInCm / 100;
            double bmi = weight / (heightInMeters * heightInMeters);

            personData[i, 2] = bmi;
        }
    }

    static string GetBMIStatus(double bmi){
        if (bmi <= 18.4)
            return "Underweight";
        else if (bmi >= 18.5 && bmi <= 24.9)
            return "Normal";
        else if (bmi >= 25.0 && bmi <= 39.9)
            return "Overweight";
        else
            return "Obese";
    }
}

