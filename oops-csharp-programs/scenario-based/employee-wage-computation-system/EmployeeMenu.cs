sealed class EmployeeMenu
{
    private IEmployee EmployeeUtility;

    public void EmployeeChoices()
    {
        EmployeeUtility = new EmployeeUtilityImpl();
        Console.WriteLine("\n=== Welcome to Employee Wage Computation Program ===\n");

        while (true)
        {
            Console.WriteLine("1. Add an employee");
            Console.WriteLine("2. Check employee Attendance");
            Console.WriteLine("3. Calculate Daily Employee Wage");
            Console.WriteLine("4. Calculate Monthly Employee Wage");
            Console.WriteLine("5. Calculate Wage Till Condition (100 hrs / 20 days)");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (EmployeeMain.Index < EmployeeMain.TotalEmployee)
                    {
                        Employee employee = EmployeeUtility.AddEmployee();
                        EmployeeMain.Employees[EmployeeMain.Index++] = employee;
                        Console.WriteLine("Employee Added Successfully\n");
                    }
                    else
                    {
                        Console.WriteLine("Employee Array is Full\n");
                    }
                    break;

                case 2:
                    bool employeeAttendance = EmployeeUtility.CheckEmployeeAttendance();
                    Console.WriteLine("Attendance: " + employeeAttendance + "\n");
                    break;

                case 3:
                    Console.WriteLine("Daily Wage: " +
                       EmployeeUtility.CalculateDailyEmployeeWage() + "\n");
                    break;
                
                case 4:
                    Console.WriteLine("Monthly Wage: " +
                        EmployeeUtility.CalculateMonthlyEmployeeWage());
                    break;

                case 5:
                    Console.WriteLine("Wage Till Condition: " +
                        EmployeeUtility.CalculateWageTillCondition());
                    break;

                case 6:
                    return;
            }
        }
    }
}
