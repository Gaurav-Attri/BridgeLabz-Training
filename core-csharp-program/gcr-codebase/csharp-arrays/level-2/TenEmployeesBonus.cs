using System;
class TenEmployeesBonus{
	static void Main(string[] args){
		double[,] employeeOldData = new double[10, 2]; // Each entry is in the form: (oldSalary, YOE)
		double[,] employeeNewData = new double[10, 2]; // Each entry is in the form: (newSalary, bonus)
		double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;
		int index = 0;
		
		// Loop to take input
		while(index < 10){
			Console.WriteLine("Please enter the salary of employee number: " + (index+1));
			double salary = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the YOE of employee number: " + (index+1));
			double YOE = double.Parse(Console.ReadLine());

			// Checking if salary or YOE is invalid
			if(salary <= 0 || YOE <= 0){
				Console.WriteLine("Please enter valid values (i.e., > 0) for salary & YOE");
				continue;
			}

			// Saving data if it is valid
			employeeOldData[index, 0] = salary;
			employeeOldData[index, 1] = YOE;
			index++;
		}

		// Calculating newSalary, bonus, totalBonus, totalOldSalary & totalNewSalary
		for(int i = 0; i < 10; i++){
			double oldSalary = employeeOldData[i, 0];
			double newSalary, bonus;
			// If YOE is less than 5 then giving 2 percent bonus
			if(employeeOldData[i, 1] < 5){
				bonus = 2.0/100 * oldSalary;
				newSalary = oldSalary + bonus;
			}
			// Otherwise giving 5 percent bonus
			else{
				bonus = 5.0/100 * oldSalary;
				newSalary = oldSalary + bonus;
			}

			employeeNewData[i, 0] = newSalary;
			employeeNewData[i, 1] = bonus;

			totalBonus += bonus;
			totalOldSalary += oldSalary;
			totalNewSalary += newSalary;
		}

		Console.WriteLine("Total Bonus Payout is: " + totalBonus);
		Console.WriteLine("Total Old Salary is: " + totalOldSalary);
		Console.WriteLine("Total New Salary is: " + totalNewSalary);
		Console.WriteLine("\n Given below is the new data for each of the 10 employees: ");

		for(int i = 0; i < 10; i++){
			Console.WriteLine("Employee " + (i+1) + "'s new salary is: " + employeeNewData[i, 0]);
			Console.WriteLine("Employee " + (i+1) + "'s bonus is: " + employeeNewData[i, 1] + "\n");
		}
	}
}
