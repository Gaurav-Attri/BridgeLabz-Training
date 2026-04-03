using System;
class StudentsGradeCalculator{
    static void Main(string[] args){
        Console.WriteLine("Enter number of students");
        int numberOfStudents = int.Parse(Console.ReadLine());

        double[,] subjectScores = ReadSubjectScores(numberOfStudents);
        double[,] summaryScores = BuildSummaryScores(subjectScores);

        Console.WriteLine("Stu\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");

        for (int index = 0; index < numberOfStudents; index++){
            double physics = subjectScores[index, 0];
            double chemistry = subjectScores[index, 1];
            double maths = subjectScores[index, 2];

            double total = summaryScores[index, 0];
            double average = summaryScores[index, 1];
            double percentage = summaryScores[index, 2];

            Console.WriteLine(
                index + 1 + "\t" +
                physics + "\t" +
                chemistry + "\t" +
                maths + "\t" +
                total + "\t" +
                average + "\t" +
                percentage);
        }
    }

    static double[,] ReadSubjectScores(int numberOfStudents){
        double[,] scores = new double[numberOfStudents, 3]; 

        for (int index = 0; index < numberOfStudents; index++){
            Console.WriteLine("Enter Physics, Chemistry and Maths marks for student " + (index + 1));
            double physics = double.Parse(Console.ReadLine());
            double chemistry = double.Parse(Console.ReadLine());
            double maths = double.Parse(Console.ReadLine());

            scores[index, 0] = physics;
            scores[index, 1] = chemistry;
            scores[index, 2] = maths;
        }

        return scores;
    }

    static double[,] BuildSummaryScores(double[,] subjectScores){
        int numberOfStudents = subjectScores.GetLength(0); 
        double[,] summary = new double[numberOfStudents, 3];

        for (int index = 0; index < numberOfStudents; index++){
            double physics = subjectScores[index, 0];
            double chemistry = subjectScores[index, 1];
            double maths = subjectScores[index, 2];

            double total = physics + chemistry + maths;
            double average = total / 3.0;
            double percentage = (total / 300.0) * 100.0;

            total = Math.Round(total, 2); 
            average = Math.Round(average, 2);
            percentage = Math.Round(percentage, 2);

            summary[index, 0] = total;
            summary[index, 1] = average;
            summary[index, 2] = percentage;
        }

        return summary;
    }
}

