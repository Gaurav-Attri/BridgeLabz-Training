
using System;
class StudentsGradeCalculator{
        static void Main(string[] args){
                Console.WriteLine("Please enter the number of students: ");
                int studentsCount = int.Parse(Console.ReadLine());

                double[,] studentsMarks = new double[studentsCount, 3]; // Stores data as [PhysicsMarks, ChemistryMarks, MathsMarks]
                double[] percentages = new double[studentsCount];
                char[] grades = new char[studentsCount];

                // Taking input of the marks
                for(int i = 0; i < studentsCount; i++){
                        Console.WriteLine("Please enter the marks of student " + (i+1) + " in Physics, Chemistry & Maths, respectively: ");
                        studentsMarks[i, 0] = double.Parse(Console.ReadLine()); // Physics Marks
                        studentsMarks[i, 1] = double.Parse(Console.ReadLine()); // Chemistry Marks
                        studentsMarks[i, 2] = double.Parse(Console.ReadLine()); // Maths Marks
                        percentages[i] = (studentsMarks[i, 0] + studentsMarks[i, 1] + studentsMarks[i, 2])/300 * 100;

                        // Evaluating grade
                        if(percentages[i] >= 80){
                                grades[i] = 'A';
                        }
                        else if(percentages[i] >= 70 && percentages[i] <= 79){
                                grades[i] = 'B';
                        }
                        else if(percentages[i] >= 60 && percentages[i] <= 69){
                                grades[i] = 'C';
                        }
                        else if(percentages[i] >= 50 && percentages[i] <= 59){
                                grades[i] = 'D';
                        }
                        else if(percentages[i] >= 40 && percentages[i] <= 49){
                                grades[i] = 'E';
                        }
                        else{
                                grades[i] = 'R';
                        }
                }

                // Displaying the results
                for(int i = 0; i < studentsCount; i++){
                        Console.WriteLine("Results of student " + (i+1) + " are as follows: ");
                        Console.WriteLine("\tMarks in Physics: " + studentsMarks[i, 0]);
                        Console.WriteLine("\tMarks in Chemistry: " + studentsMarks[i, 1]);
                        Console.WriteLine("\tMarks in Maths: " + studentsMarks[i, 2]);
                        Console.WriteLine("\tPercentage: " + percentages[i]);
                        Console.WriteLine("\tGrade: " + grades[i]);
                }
        }
}
