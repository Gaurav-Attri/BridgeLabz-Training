using System;
class BonusCalculator{
    static void Main(string[] args){
        int employeeCount = 10;
        double[,] oldDetails = BuildOldDetails(employeeCount);
        double[,] newDetails = BuildNewDetails(oldDetails);

        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        Console.WriteLine("Emp OldSalary Years Bonus NewSalary");

        for (int index = 0; index < employeeCount; index++){
            double oldSalary = oldDetails[index, 0];
            double years = oldDetails[index, 1];
            double bonus = newDetails[index, 0];
            double newSalary = newDetails[index, 1];

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            Console.WriteLine(index + 1 + " " + oldSalary + " " + years + " " + bonus + " " + newSalary);
        }

        Console.WriteLine("TotalOldSalary " + totalOldSalary);
        Console.WriteLine("TotalNewSalary " + totalNewSalary);
        Console.WriteLine("TotalBonus " + totalBonus);
    }

    static double[,] BuildOldDetails(int employeeCount){
        double[,] details = new double[employeeCount, 2]; 
        Random random = new Random();

        for (int index = 0; index < employeeCount; index++){
            int salary = random.Next(10000, 100000);
            int years = random.Next(0, 11);

            details[index, 0] = salary;
            details[index, 1] = years;
        }

        return details;
    }

    static double[,] BuildNewDetails(double[,] oldDetails){
        int employeeCount = oldDetails.GetLength(0);
        double[,] latest = new double[employeeCount, 2];

        for (int index = 0; index < employeeCount; index++){
            double salary = oldDetails[index, 0];
            double years = oldDetails[index, 1];

            double rate = years > 5 ? 0.05 : 0.02;
            double bonus = salary * rate;
            double newSalary = salary + bonus;

            latest[index, 0] = bonus;
            latest[index, 1] = newSalary;
        }

        return latest;
    }
}

